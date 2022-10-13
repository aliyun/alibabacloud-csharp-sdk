// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class ListTasksResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTasksResponseBodyData Data { get; set; }
        public class ListTasksResponseBodyData : TeaModel {
            [NameInMap("BizTypes")]
            [Validation(Required=false)]
            public string BizTypes { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListTasksResponseBodyDataList> List { get; set; }
            public class ListTasksResponseBodyDataList : TeaModel {
                [NameInMap("AccountNo")]
                [Validation(Required=false)]
                public string AccountNo { get; set; }

                [NameInMap("AccountStatus")]
                [Validation(Required=false)]
                public long? AccountStatus { get; set; }

                [NameInMap("ActualBankRegisterVO")]
                [Validation(Required=false)]
                public ListTasksResponseBodyDataListActualBankRegisterVO ActualBankRegisterVO { get; set; }
                public class ListTasksResponseBodyDataListActualBankRegisterVO : TeaModel {
                    [NameInMap("InComingPartsNumber")]
                    [Validation(Required=false)]
                    public long? InComingPartsNumber { get; set; }

                    [NameInMap("PlaceOrderNumber")]
                    [Validation(Required=false)]
                    public long? PlaceOrderNumber { get; set; }

                    [NameInMap("SwipingCardNumber")]
                    [Validation(Required=false)]
                    public long? SwipingCardNumber { get; set; }

                    [NameInMap("VerificationCardNumber")]
                    [Validation(Required=false)]
                    public long? VerificationCardNumber { get; set; }

                    [NameInMap("VisaInterviewNumber")]
                    [Validation(Required=false)]
                    public long? VisaInterviewNumber { get; set; }

                }

                [NameInMap("ActualCommonSceneVO")]
                [Validation(Required=false)]
                public Dictionary<string, string> ActualCommonSceneVO { get; set; }

                [NameInMap("ActualConsumeAmount")]
                [Validation(Required=false)]
                public long? ActualConsumeAmount { get; set; }

                [NameInMap("ActualInfo")]
                [Validation(Required=false)]
                public string ActualInfo { get; set; }

                [NameInMap("BrandActualResultNumber")]
                [Validation(Required=false)]
                public long? BrandActualResultNumber { get; set; }

                [NameInMap("BrandPredictResultNumber")]
                [Validation(Required=false)]
                public long? BrandPredictResultNumber { get; set; }

                [NameInMap("BrandUserId")]
                [Validation(Required=false)]
                public long? BrandUserId { get; set; }

                [NameInMap("BrandUserNick")]
                [Validation(Required=false)]
                public string BrandUserNick { get; set; }

                [NameInMap("CouponNewActualResultNumber")]
                [Validation(Required=false)]
                public long? CouponNewActualResultNumber { get; set; }

                [NameInMap("CouponNewPredictResultNumber")]
                [Validation(Required=false)]
                public long? CouponNewPredictResultNumber { get; set; }

                [NameInMap("CouponNewPriceStep")]
                [Validation(Required=false)]
                public long? CouponNewPriceStep { get; set; }

                [NameInMap("CouponOldActualResultNumber")]
                [Validation(Required=false)]
                public long? CouponOldActualResultNumber { get; set; }

                [NameInMap("CouponOldPredictResultNumber")]
                [Validation(Required=false)]
                public long? CouponOldPredictResultNumber { get; set; }

                [NameInMap("CouponOldPriceStep")]
                [Validation(Required=false)]
                public long? CouponOldPriceStep { get; set; }

                [NameInMap("CurrencyType")]
                [Validation(Required=false)]
                public long? CurrencyType { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("LoginActualResultNumber")]
                [Validation(Required=false)]
                public long? LoginActualResultNumber { get; set; }

                [NameInMap("LoginPredictResultNumber")]
                [Validation(Required=false)]
                public long? LoginPredictResultNumber { get; set; }

                [NameInMap("MainId")]
                [Validation(Required=false)]
                public long? MainId { get; set; }

                [NameInMap("MainType")]
                [Validation(Required=false)]
                public long? MainType { get; set; }

                [NameInMap("OpNick")]
                [Validation(Required=false)]
                public string OpNick { get; set; }

                [NameInMap("OrderActualResultNumber")]
                [Validation(Required=false)]
                public long? OrderActualResultNumber { get; set; }

                [NameInMap("OrderPredictResultNumber")]
                [Validation(Required=false)]
                public long? OrderPredictResultNumber { get; set; }

                [NameInMap("PredictBankRegisterVO")]
                [Validation(Required=false)]
                public ListTasksResponseBodyDataListPredictBankRegisterVO PredictBankRegisterVO { get; set; }
                public class ListTasksResponseBodyDataListPredictBankRegisterVO : TeaModel {
                    [NameInMap("InComingPartsNumber")]
                    [Validation(Required=false)]
                    public long? InComingPartsNumber { get; set; }

                    [NameInMap("PlaceOrderNumber")]
                    [Validation(Required=false)]
                    public long? PlaceOrderNumber { get; set; }

                    [NameInMap("SwipingCardNumber")]
                    [Validation(Required=false)]
                    public long? SwipingCardNumber { get; set; }

                    [NameInMap("VerificationCardNumber")]
                    [Validation(Required=false)]
                    public long? VerificationCardNumber { get; set; }

                    [NameInMap("VisaInterviewNumber")]
                    [Validation(Required=false)]
                    public long? VisaInterviewNumber { get; set; }

                }

                [NameInMap("PredictCommonSceneVO")]
                [Validation(Required=false)]
                public Dictionary<string, string> PredictCommonSceneVO { get; set; }

                [NameInMap("PredictConsumeAmount")]
                [Validation(Required=false)]
                public long? PredictConsumeAmount { get; set; }

                [NameInMap("PredictInfo")]
                [Validation(Required=false)]
                public string PredictInfo { get; set; }

                [NameInMap("PriceType")]
                [Validation(Required=false)]
                public long? PriceType { get; set; }

                [NameInMap("ProxyUserId")]
                [Validation(Required=false)]
                public long? ProxyUserId { get; set; }

                [NameInMap("ProxyUserNick")]
                [Validation(Required=false)]
                public string ProxyUserNick { get; set; }

                [NameInMap("ScheduleTime")]
                [Validation(Required=false)]
                public string ScheduleTime { get; set; }

                [NameInMap("ScheduleType")]
                [Validation(Required=false)]
                public long? ScheduleType { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                [NameInMap("SystemActualConsumeAmount")]
                [Validation(Required=false)]
                public long? SystemActualConsumeAmount { get; set; }

                [NameInMap("TargetUrl")]
                [Validation(Required=false)]
                public string TargetUrl { get; set; }

                [NameInMap("TaskGroupId")]
                [Validation(Required=false)]
                public long? TaskGroupId { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                [NameInMap("TaskMarketingType")]
                [Validation(Required=false)]
                public long? TaskMarketingType { get; set; }

                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

            }

            [NameInMap("TaskRules")]
            [Validation(Required=false)]
            public string TaskRules { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
