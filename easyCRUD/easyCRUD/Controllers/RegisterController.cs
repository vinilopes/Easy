using System;
using easyCRUD.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace easyCRUD.Controllers
{
    public class RegisterController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public String insert_Candidato(candidato Cand) {
            if (Cand != null)
            {
                using (easydbEntitiesModel Obj = new easydbEntitiesModel())
                {
                    Obj.candidatos.Add(Cand);
                    Obj.SaveChanges();
                    return "Candidato Cadastrado!";
                }
            }
            else
            {
                return "Erro";
            }
        }

        public JsonResult Get_AllCandidates() {  
                using(easydbEntitiesModel Obj = new easydbEntitiesModel()) {
                    List < candidato > Cand = Obj.candidatos.ToList();
                return Json(Cand, JsonRequestBehavior.AllowGet);  
                }  
            }

        public JsonResult Get_AllCandidatesFilter(FilterTable a)
        {
            using (easydbEntitiesModel Obj = new easydbEntitiesModel())
            {
                List<candidato> Cand;
                switch (a.codigo)
                {
                    case 1:
                        Cand = Obj.candidatos.OrderByDescending(x => x.nome).ToList();
                        break;
                    case 2:
                        Cand = Obj.candidatos.OrderByDescending(x => x.salario).ToList();
                        break;
                    default:
                        Cand = Obj.candidatos.ToList();
                        break;
                }
                return Json(Cand, JsonRequestBehavior.AllowGet);
            }
        }


        public JsonResult Get_LastId()
        {
            using (easydbEntitiesModel Obj = new easydbEntitiesModel())
            {
                candidato Cand = Obj.candidatos.OrderByDescending(x => x.codigo).FirstOrDefault();
                return Json(Cand, JsonRequestBehavior.AllowGet);
            }
        }

        public string Delete_Candidate(candidato Cand)
        {
            if (Cand != null)
            {
                using (easydbEntitiesModel Obj = new easydbEntitiesModel())
                {
                    var Cand_ = Obj.Entry(Cand);
                    if (Cand_.State == System.Data.Entity.EntityState.Detached)
                    {
                        Obj.candidatos.Attach(Cand);
                        Obj.candidatos.Remove(Cand);
                    }
                    Obj.SaveChanges();
                    return "Candidadto Deletado!";
                }
            }
            else
            {
                return "Erro";
            }
        }


        public string Update_Candidate(candidato Cand)
        {
            if (Cand != null)
            {
                using (easydbEntitiesModel Obj = new easydbEntitiesModel())
                {
                    var Cand_ = Obj.Entry(Cand);
                    candidato CandObj = Obj.candidatos.Where(x => x.codigo == Cand.codigo).FirstOrDefault();
                    CandObj.email = Cand.email;
                    CandObj.nome = Cand.nome;
                    CandObj.skype = Cand.skype;
                    CandObj.telefone = Cand.telefone;
                    CandObj.linkedin = Cand.linkedin;
                    CandObj.cidade = Cand.cidade;
                    CandObj.estado = Cand.estado;
                    CandObj.portfolio = Cand.portfolio;
                    CandObj.disponibilidade = Cand.disponibilidade;
                    CandObj.horario = Cand.horario;
                    CandObj.salario = Cand.salario;
                    CandObj.informacao_bancaria = Cand.informacao_bancaria;
                    CandObj.conta_nome = Cand.conta_nome;
                    CandObj.cpf = Cand.cpf;
                    CandObj.banco_nome = Cand.banco_nome;
                    CandObj.agencia = Cand.agencia;
                    CandObj.conta = Cand.conta;
                    CandObj.ionic = Cand.ionic;
                    CandObj.android = Cand.android;
                    CandObj.ios = Cand.ios;
                    CandObj.html = Cand.html;
                    CandObj.css = Cand.css;
                    CandObj.bootstrap = Cand.bootstrap;
                    CandObj.jquery = Cand.jquery;
                    CandObj.angularjs = Cand.angularjs;
                    CandObj.java = Cand.java;
                    CandObj.aspnet_mvc = Cand.aspnet_mvc;
                    CandObj.c = Cand.c;
                    CandObj.c_plusplus = Cand.c_plusplus;
                    CandObj.cake = Cand.cake;
                    CandObj.django = Cand.django;
                    CandObj.majento = Cand.majento;
                    CandObj.php = Cand.php;
                    CandObj.vue = Cand.vue;
                    CandObj.wordpress = Cand.wordpress;
                    CandObj.phyton = Cand.phyton;
                    CandObj.ruby = Cand.ruby;
                    CandObj.sql_server = Cand.sql_server;
                    CandObj.my_sql = Cand.my_sql;
                    CandObj.salesforce = Cand.salesforce;
                    CandObj.photoshop = Cand.photoshop;
                    CandObj.illustrator = Cand.illustrator;
                    CandObj.seo = Cand.seo;
                    CandObj.tipo_conta_corrente = Cand.tipo_conta_corrente;
                    CandObj.tipo_conta_poupanca = Cand.tipo_conta_poupanca;
                    CandObj.crud = Cand.crud;

                    Obj.SaveChanges();
                    return "Candidato Atualizado";
                }
            }
            else
            {
                return "Erro";
            }
        }

    }
}