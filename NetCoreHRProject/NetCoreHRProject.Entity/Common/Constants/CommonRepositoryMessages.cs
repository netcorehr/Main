using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreHRProject.Entity.Common.Constants
{
    public static class CommonRepositoryMessages
    {
        public const string NotFoundMessage = "لا توجد معلومات";
        public const string NotFoundDetails = "لا توجد معلومات بالبحث المرفق تنتمي للرقم المرجعي المرفق";


        public const string NotFoundMessageEN = "No data found";
        public const string NotFoundDetailsEN = "No data found that related to the search criteria";

        public const string CannotInsertMessage = "Cannot add";
        public const string CannotInsertDetailsEnglish = "Cannot add, Please contact technical support";
        public const string CannotInsertDetails = "الاضافة غير ممكنة الرجاء مراجعة مسؤول النظام";

        public const string CannotUpdateMessage = "التعديل غير ممكن";
        public const string CannotUpdateDetails = "التعديل غير ممكن الرجاء مراجعة مسؤول النظام";

        public const string CannotUpdateMessageEN = "Cannot Update";
        public const string CannotUpdateDetailsEN = "Cannot Update, Please contact technical support";

        public const string CannotDeleteMessage = "الحذف غير ممكن";
        public const string CannotDeleteDetails = "الحذف غير ممكن الرجاء مراجعة مسؤول النظام";

        public const string CannotDeleteMessageEN = "Cannot Delete";
        public const string CannotDeleteDetailsEN = "Cannot Delete, Please contact technical support";

        public const string CannotFindByIDMessage = "لا توجد بيانات";
        public const string CannotFindByIDDetails = "الرقم المرجعي السابق غير موجود";

        public const string CannotFindByIDMessageEN = "No data found";
        public const string CannotFindByIDDetailsEN = "No data found related to the current id";

        public const string CannotFindAllMessage = "لا توجد بيانات";
        public const string CannotFindAllDetails = "لا توجد بيانات";

        public const string CannotFindAllMessageEN = "No data found";
        public const string CannotFindAllDetailsEN = "No data found";

        public const string InsertSuccessMessage = "تم الحفظ بنجـاح";
        public const string InsertSuccessMessageEn = "Saved successfully";
        public const string DeleteSuccessMessage = "تم الحذف بنجـاح";
        public const string DeleteSuccessMessageEn = "Deleted successfully";
        public const string UpdateSuccessMessage = "تم التعديل بنجـاح";
        public const string UpdateSuccessMessageEn = "Modified successfully";
        public const string RejectedSuccessMessage = "تم الرفض بنجاح";
        public const string RejectedSuccessMessageEn = "Rejected successfully";
        public const string AcceptedSuccessMessage = "مقبول بنجاح";
        public const string AcceptedSuccessMessageEn = "Accepted successfully";

        public const string ExceptionMessage = "حدث خطأ غير متوقع الرجاء مراجعة مسؤول النظام";
        public const string ExceptionMessageEn = "An unexpected error occurred, please see the system administrator";
        public const string AlreadyExistMessage = "Record Already Exist";
        public const string AlreadyExistMeassageEn = "Record Already Exist";
    }
}
