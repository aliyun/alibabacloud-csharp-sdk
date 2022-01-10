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
                public string AccountNo { get; set; }
                public long? AccountStatus { get; set; }
                public long? ActualConsumeAmount { get; set; }
                public long? BrandActualResultNumber { get; set; }
                public long? BrandPredictResultNumber { get; set; }
                public long? BrandUserId { get; set; }
                public string BrandUserNick { get; set; }
                public long? CouponNewActualResultNumber { get; set; }
                public long? CouponNewPredictResultNumber { get; set; }
                public long? CouponNewPriceStep { get; set; }
                public long? CouponOldActualResultNumber { get; set; }
                public long? CouponOldPredictResultNumber { get; set; }
                public long? CouponOldPriceStep { get; set; }
                public long? EndTime { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public long? Id { get; set; }
                public long? LoginActualResultNumber { get; set; }
                public long? LoginPredictResultNumber { get; set; }
                public long? MainId { get; set; }
                public long? MainType { get; set; }
                public string OpNick { get; set; }
                public long? OrderActualResultNumber { get; set; }
                public long? OrderPredictResultNumber { get; set; }
                public long? PredictConsumeAmount { get; set; }
                public long? PriceType { get; set; }
                public long? ProxyUserId { get; set; }
                public string ProxyUserNick { get; set; }
                public string ScheduleTime { get; set; }
                public long? ScheduleType { get; set; }
                public long? StartTime { get; set; }
                public long? Status { get; set; }
                public long? SystemActualConsumeAmount { get; set; }
                public string TargetUrl { get; set; }
                public long? TaskGroupId { get; set; }
                public long? TaskId { get; set; }
                public long? TaskMarketingType { get; set; }
                public string TaskName { get; set; }
                public string TaskType { get; set; }
            }
            [NameInMap("TaskRules")]
            [Validation(Required=false)]
            public string TaskRules { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }
        };

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
