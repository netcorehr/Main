using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreHRProject.Entity.Common.Constants
{
    public static class CommonDomainMessages
    {
        public const string Err_ValidationError = "الرجاء التأكد من فعالية البيانات المدخلة";
        public const string Err_ValidationErrorEn = "Please check the data validation";

        public const string Err_UsernameExist = "الرجاء اختيار اسم مستخدم اخر الاسم الحالي محجوز";
        public const string Err_UsernameExistEn = "Please choose another username, current username reserved";

        public const string Mes_LoginSuccess = "تم تسجيل الدخول بنجاح";
        public const string Mes_LoginSuccessEn = "Login Successful";

        public const string Err_OTPSuccess = "تم التحقق من مكتب المدعي العام بنجاح";
        public const string Err_OTPSuccessEN = "OTP verified Successfully";

        public const string Err_OTPWrong = "خطأ مكتب المدعي العام يرجى المحاولة مرة أخرى";
        public const string Err_OTPWrongEN = "OTP wrong please try again";


        public const string Err_AccountAlreadyActivated = "الحساب مفعل مسبقا";
        public const string Err_AccountAlreadyActivatedEn = "Account already activated";

        public const string Err_ActivationCodeWrong = "رمز التفعيل المدخل خطأ الرجاء المحاولة مرة اخرى";
        public const string Err_ActivationCodeWrongEN = "Activation code wrong please try again";

        public const string Err_MobileNumberExist = "رقم الجوال المدخل الحالي مسجل مسبقا الرجاء التأكد من رقم الجوال او ادخال رقم اخر";
        public const string Err_MobileNumberExistEn = "The current mobile number already registered please check mobile number or add new mobile number";


        public const string Inf_MessageSentSuccessfully = "تم الارسال بنجاح";
        public const string Inf_MessageSentSuccessfullyEn = "Message sent successfully";

        public const string Err_NoBalance = "لايوجد رصيد للارسال";
        public const string Err_NoBalanceEn = "There is no balance for sms to send";

        public const string Err_WrongUsername = "اسم المستخدم خطأ";
        public const string Err_WrongUsernameEn = "Wrong username";

        public const string Err_WrongPassword = "كلمة المرور خطأ";
        public const string Err_WrongPasswordEn = "Wrong password";

        public const string Err_SMSGatewayNoResponse = "بوابة الرسائل لا تستجيب الرجاء الارسال مرة اخرى";
        public const string Err_SMSGatewayNoResponseEn = "SMS gateway dosent response please resend again";

        public const string Err_WrongSenderShortCode = "اسم المرسل غير مقبول";
        public const string Err_WrongSenderShortCodeEn = "Sender name undefined";

        public const string Err_WrongMobileNumber = "الارقام المرسل اليها غير صحيحة او فارغة";
        public const string Err_WrongMobileNumberEn = "client mobile number is wrong or empty";

        public const string Err_HostReach = "حث خطأ في الوصول الى خادم الارسال";
        public const string Err_HostReachEn = "Error of contacting sms server";

        public const string Err_MessageTemplateNotFound = "لم يتم العثور على قالب الرسالة";
        public const string Err_MessageTemplateNotFoundEn = "Message template not found";

        public const string Err_WrongUsernameOrPassword = "اسم المستخدم او كلمة المرور خطأ";
        public const string Err_WrongUsernameOrPasswordEn = "Wrong username or password";

        public const string Err_AccountNotActivatedYet = "لم يتم تفعيل الحساب بعد الرجاء ادخال الرمز المرسل للتفعيل";
        public const string Err_AccountNotActivatedYetEn = "Account not activated yet please reactivate your account by add the sent account to your mobile";

        public const string Err_DriverNotActive = "عذرا ، تم تعطيل حسابك من قبل المشرف. يرجى الاتصال بمركز الاتصال.";
        public const string Err_DriverNotActiveEn = "Sorry, Your account is disabled by admin. Please contact call center.";

        public const string Err_DriverNotApproval = "طلبك في انتظار موافقة المسؤول. يرجى الاتصال بمركز الاتصال.";
        public const string Err_DriverNotApprovalEn = "Your request is pending for admin approval. Please contact call center.";


        public const string Err_ServerError = "حدث خطأ في مزود الخدمة الرجاء التواصل مع الدعم الفني";
        public const string Err_ServerErrorEn = "Unexpected error in service provider please contact technical support";


        public const string Err_NoServiceProviderBelongToTheProvidedCodeEn = "No service provider belong to the provided code";
        public const string Err_NoServiceProviderBelongToTheProvidedCode = "لايوجد مقدم خدمة ينتمي للرمز المدخل";

        public const string Err_NoRegisteredInformationEn = "user name or mobile number desn't registered with us";
        public const string Err_NoRegisteredInformation = "اسم المستخدم او رقم الهاتف غير مسجل لدينا";



        public const string Err_CodeExistEn = "Code already exist";
        public const string Err_CodeExist = "الرمز موجود مسبقا";

        public const string Err_UserTypeAlreadyExistEn = "User type already added before";
        public const string Err_UserTypeAlreadyExist = "الصلاحية مضافة مسبقا";


        public const string Err_ItemNotFoundEn = "Item not found";
        public const string Err_ItemNotFound = "لم يتم العثور على العنصر المحدد";

    }
}