

var app = angular.module("myApp", []);
app.controller("myCtrl", function ($scope, $http) {
    
    $scope.formName = "";
    $scope.FilterTable = {};
    $scope.candidate = {};

    $('#ModalTalent').on('shown.bs.modal', function (e) {
        $("#ModalTalent").modal('show');
        $("#ModalTalent").scrollTop(0);
    })
   
    $scope.selectedFilter = function () {
        $scope.FilterTable.codigo = $scope.selectedItem;
        $http({
            method: "post",
            url: "http://localhost:44373/Register/Get_AllCandidatesFilter",
            datatype: "json",
            data: JSON.stringify($scope.FilterTable)
        }).then(function (response) {
            $scope.candidatos = response.data;
        }, function () {
            alert("Error Occur");
        })
    }

    $scope.modal = function () {
        $scope.consult = false;
        $scope.formName = "Seus dados";
    }

    $scope.resetAllData = function () {
        $scope.candidateEmail = "";
        $scope.candidateName = "";
        $scope.candidateSkype = "";
        $scope.candidatePhone = "";
        $scope.candidateLinkedin = "";
        $scope.candidateCity = "";
        $scope.candidateState = "";
        $scope.candidatePortfolio = "";
        $scope.optionsRadiosDisponibility = "";
        $scope.optionsRadiosTime = "";
        $scope.candidateSalary = "";
        $scope.candidateBankInformation = "";
        $scope.candidateBankNameAccount = "";
        $scope.candidateCpf = "";
        $scope.candidateBankName = "";
        $scope.candidateAgency = "";
        $scope.candidateAccount = "";
        $scope.candidateIonic = "";
        $scope.candidateAndroid = "";
        $scope.candidateIOS = "";
        $scope.candidateHTML = "";
        $scope.candidateCss = "";
        $scope.candidateBootstrap = "";
        $scope.candidateJquery = "";
        $scope.candidateAngularJs = "";
        $scope.candidateJava = "";
        $scope.candidateAsp = "";
        $scope.candidateC = "";
        $scope.candidateCPlusPlus = "";
        $scope.candidateCake = "";
        $scope.candidateDjango = "";
        $scope.candidateMajento = "";
        $scope.candidatePHP = "";
        $scope.candidateVue = "";
        $scope.candidateWordpress = "";
        $scope.candidatePhyton = "";
        $scope.candidateRuby = "";
        $scope.candidateSqlServer = "";
        $scope.candidateMySql = "";
        $scope.candidateSalesforce = "";
        $scope.candidatePhotoshop = "";
        $scope.candidateIllustrator = "";
        $scope.candidateSEO = "";
        $scope.candidateTypeAcconuntChain = "";
        $scope.candidateTypeAcconuntSavings = "";
        $scope.candidateCrud = "";
    };

    $scope.InsertData = function () {
        
        var Action = document.getElementById("btnSave").getAttribute("value");
        $scope.candidate.email = $scope.candidateEmail;
        $scope.candidate.nome = $scope.candidateName;
        $scope.candidate.skype = $scope.candidateSkype;
        $scope.candidate.telefone = $scope.candidatePhone;
        $scope.candidate.linkedin = $scope.candidateLinkedin;
        $scope.candidate.cidade = $scope.candidateCity;
        $scope.candidate.estado = $scope.candidateState;
        $scope.candidate.portfolio = $scope.candidatePortfolio;
        $scope.candidate.disponibilidade = $scope.optionsRadiosDisponibility;
        $scope.candidate.horario = $scope.optionsRadiosTime;
        $scope.candidate.salario = $scope.candidateSalary;
        $scope.candidate.informacao_bancaria = $scope.candidateBankInformation;
        $scope.candidate.conta_nome = $scope.candidateBankNameAccount;
        $scope.candidate.cpf = $scope.candidateCpf;
        $scope.candidate.banco_nome = $scope.candidateBankName;
        $scope.candidate.agencia = $scope.candidateAgency;
        $scope.candidate.conta = $scope.candidateAccount;
        $scope.candidate.ionic = $scope.candidateIonic;
        $scope.candidate.android = $scope.candidateAndroid;
        $scope.candidate.ios = $scope.candidateIOS;
        $scope.candidate.html = $scope.candidateHTML;
        $scope.candidate.css = $scope.candidateCss;
        $scope.candidate.bootstrap = $scope.candidateBootstrap;
        $scope.candidate.jquery = $scope.candidateJquery;
        $scope.candidate.angularjs = $scope.candidateAngularJs;
        $scope.candidate.java = $scope.candidateJava;
        $scope.candidate.aspnet_mvc = $scope.candidateAsp;
        $scope.candidate.c = $scope.candidateC;
        $scope.candidate.c_plusplus = $scope.candidateCPlusPlus;
        $scope.candidate.cake = $scope.candidateCake;
        $scope.candidate.django = $scope.candidateDjango;
        $scope.candidate.majento = $scope.candidateMajento;
        $scope.candidate.php = $scope.candidatePHP;
        $scope.candidate.vue = $scope.candidateVue;
        $scope.candidate.wordpress = $scope.candidateWordpress;
        $scope.candidate.phyton = $scope.candidatePhyton;
        $scope.candidate.ruby = $scope.candidateRuby;
        $scope.candidate.sql_server = $scope.candidateSqlServer;
        $scope.candidate.my_sql = $scope.candidateMySql;
        $scope.candidate.salesforce = $scope.candidateSalesforce;
        $scope.candidate.photoshop = $scope.candidatePhotoshop;
        $scope.candidate.illustrator = $scope.candidateIllustrator;
        $scope.candidate.seo = $scope.candidateSEO;
        $scope.candidate.tipo_conta_corrente = $scope.candidateTypeAcconuntChain;
        $scope.candidate.tipo_conta_poupanca = $scope.candidateTypeAcconuntSavings;
        $scope.candidate.crud = $scope.candidateCrud;

        if (Action == "Cadastrar") {

            $http({
                method: "get",
                url: "http://localhost:44373/Register/Get_LastId"
                }).then(function (response) {
                    $scope.candidatedb = response.data;
                    $scope.candidate.codigo = $scope.candidatedb.codigo + 1;
                    $http({
                        method: "post",
                        url: "http://localhost:44373/Register/insert_Candidato",
                        datatype: "json",
                        data: JSON.stringify($scope.candidate)
                    }).then(function (response) {
                        $('#ModalTalent').modal('hide');
                        $scope.GetAllData();
                        $scope.resetAllData();
                    })
                });
        } else {  
            $scope.candidate.codigo = document.getElementById("CandID_").value;
            $http({  
                method: "post",  
                url: "http://localhost:44373/Register/Update_Candidate",
                datatype: "json",  
                data: JSON.stringify($scope.candidate)
            }).then(function (response) {
                $('#ModalTalent').modal('hide');
                $scope.GetAllData();
                $scope.resetAllData();
                document.getElementById("btnSave").setAttribute("value", "Cadastrar");  
            })  
        }  
    }

    $scope.GetAllData = function() {  
        $http({  
            method: "get",
            url: "http://localhost:44373/Register/Get_AllCandidates"
        }).then(function(response) {  
            $scope.candidatos = response.data;  
        }, function() {  
            alert("Error");  
        })  
    };

    $scope.GetMaxId = function () {
        $http({
            method: "get",
            url: "http://localhost:44373/Register/Get_LastId"
        }).then(function (response) {
            $scope.candidatodb = response.data;
        }, function () {
            alert("Error");
        })
    };

    $scope.ConsultCandidate = function (Cand) {
        $("#ModalTalent").scrollTop(0);
        $scope.consult = true;
        $scope.formName = "Consulta completa";
        $scope.candidateEmail = Cand.email;
        $scope.candidateName = Cand.nome;
        $scope.candidateSkype = Cand.skype;
        $scope.candidatePhone = Cand.telefone;
        $scope.candidateLinkedin = Cand.linkedin;
        $scope.candidateCit = Cand.cidade;
        $scope.candidateState = Cand.estado;
        $scope.candidatePortfolio = Cand.portfolio;
        $scope.optionsRadiosDisponibility = Cand.disponibilidade;
        $scope.optionsRadiosTime = Cand.horario;
        $scope.candidateSalary = Cand.salario;
        $scope.candidateBankInformation = Cand.informacao_bancaria;
        $scope.candidateBankNameAccount = Cand.conta_nome;
        $scope.candidateCpf = Cand.cpf;
        $scope.candidateBankName = Cand.banco_nome;
        $scope.candidateAgency = Cand.agencia;
        $scope.candidateAccount = Cand.conta;
        $scope.candidateIonic = Cand.ionic;
        $scope.candidateAndroid = Cand.android;
        $scope.candidateIOS = Cand.ios;
        $scope.candidateHTML = Cand.html;
        $scope.candidateCss = Cand.css;
        $scope.candidateBootstrap = Cand.bootstrap;
        $scope.candidateJquery = Cand.jquery;
        $scope.candidateAngularJs = Cand.angularjs;
        $scope.candidateJava = Cand.java;
        $scope.candidateAsp = Cand.aspnet_mvc;
        $scope.candidateC = Cand.c;
        $scope.candidateCPlusPlus = Cand.c_plusplus;
        $scope.candidateCake = Cand.cake;
        $scope.candidateDjango = Cand.django;
        $scope.candidateMajento = Cand.majento;
        $scope.candidatePHP = Cand.php;
        $scope.candidateVue = Cand.vue;
        $scope.candidateWordpress = Cand.wordpress;
        $scope.candidatePhyton = Cand.phyton;
        $scope.candidateRuby = Cand.ruby;
        $scope.candidateSqlServer = Cand.sql_server;
        $scope.candidateMySql = Cand.my_sql;
        $scope.candidateSalesforce = Cand.salesforce;
        $scope.candidatePhotoshop = Cand.photoshop;
        $scope.candidateIllustrator = Cand.illustrator;
        $scope.candidateSEO = Cand.seo;
        $scope.candidateTypeAcconuntChain = Cand.tipo_conta_corrente;
        $scope.candidateTypeAcconuntSavings = Cand.tipo_conta_poupanca;
        $scope.candidateCrud = Cand.crud;
    };

    $scope.DeleteCandidate = function (Cand) {
        $http({  
            method: "post",  
            url: "http://localhost:44373/Register/Delete_Candidate",
            datatype: "json",  
            data: JSON.stringify(Cand)  
        }).then(function(response) {  
            alert(response.data);  
            $scope.GetAllData();  
        })  
    };

    $scope.UpdateCandidate = function (Cand) {
        $("#ModalTalent").scrollTop(0);
        document.getElementById("CandID_").value = Cand.codigo;
        $scope.consult = false;
        $scope.formName = "Seus dados";
        $scope.candidateEmail = Cand.email;
        $scope.candidateName = Cand.nome;
        $scope.candidateSkype = Cand.skype;
        $scope.candidatePhone = Cand.telefone;
        $scope.candidateLinkedin = Cand.linkedin;
        $scope.candidateCity = Cand.cidade;
        $scope.candidateState = Cand.estado;
        $scope.candidatePortfolio = Cand.portfolio;
        $scope.optionsRadiosDisponibility = Cand.disponibilidade;
        $scope.optionsRadiosTime = Cand.horario;
        $scope.candidateSalary = Cand.salario;
        $scope.candidateBankInformation = Cand.informacao_bancaria;
        $scope.candidateBankNameAccount = Cand.conta_nome;
        $scope.candidateCpf = Cand.cpf;
        $scope.candidateBankName = Cand.banco_nome;
        $scope.candidateAgency = Cand.agencia;
        $scope.candidateAccount = Cand.conta;
        $scope.candidateIonic = Cand.ionic;
        $scope.candidateAndroid = Cand.android;
        $scope.candidateIOS = Cand.ios;
        $scope.candidateHTML = Cand.html;
        $scope.candidateCss = Cand.css;
        $scope.candidateBootstrap = Cand.bootstrap;
        $scope.candidateJquery = Cand.jquery;
        $scope.candidateAngularJs = Cand.angularjs;
        $scope.candidateJava = Cand.java;
        $scope.candidateAsp = Cand.aspnet_mvc;
        $scope.candidateC = Cand.c;
        $scope.candidateCPlusPlus = Cand.c_plusplus;
        $scope.candidateCake = Cand.cake;
        $scope.candidateDjango = Cand.django;
        $scope.candidateMajento = Cand.majento;
        $scope.candidatePHP = Cand.php;
        $scope.candidateVue = Cand.vue;
        $scope.candidateWordpress = Cand.wordpress;
        $scope.candidatePhyton = Cand.phyton;
        $scope.candidateRuby = Cand.ruby;
        $scope.candidateSqlServer = Cand.sql_server;
        $scope.candidateMySql = Cand.my_sql;
        $scope.candidateSalesforce = Cand.salesforce;
        $scope.candidatePhotoshop = Cand.photoshop;
        $scope.candidateIllustrator = Cand.illustrator;
        $scope.candidateSEO = Cand.seo;
        $scope.candidateTypeAcconuntChain = Cand.tipo_conta_corrente;
        $scope.candidateTypeAcconuntSavings = Cand.tipo_conta_poupanca;
        $scope.candidateCrud = Cand.crud;
        document.getElementById("btnSave").setAttribute("value", "Atualizar");
    };
})
