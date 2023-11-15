// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAlertsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAlertsResponseBodyData Data { get; set; }
        public class DescribeAlertsResponseBodyData : TeaModel {
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeAlertsResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeAlertsResponseBodyDataPageInfo : TeaModel {
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<DescribeAlertsResponseBodyDataResponseData> ResponseData { get; set; }
            public class DescribeAlertsResponseBodyDataResponseData : TeaModel {
                [NameInMap("AlertDesc")]
                [Validation(Required=false)]
                public string AlertDesc { get; set; }

                [NameInMap("AlertDescCode")]
                [Validation(Required=false)]
                public string AlertDescCode { get; set; }

                [NameInMap("AlertDescEn")]
                [Validation(Required=false)]
                public string AlertDescEn { get; set; }

                [NameInMap("AlertDetail")]
                [Validation(Required=false)]
                public string AlertDetail { get; set; }

                [NameInMap("AlertInfoList")]
                [Validation(Required=false)]
                public List<DescribeAlertsResponseBodyDataResponseDataAlertInfoList> AlertInfoList { get; set; }
                public class DescribeAlertsResponseBodyDataResponseDataAlertInfoList : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("KeyName")]
                    [Validation(Required=false)]
                    public string KeyName { get; set; }

                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public string Values { get; set; }

                }

                [NameInMap("AlertLevel")]
                [Validation(Required=false)]
                public string AlertLevel { get; set; }

                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                [NameInMap("AlertNameCode")]
                [Validation(Required=false)]
                public string AlertNameCode { get; set; }

                [NameInMap("AlertNameEn")]
                [Validation(Required=false)]
                public string AlertNameEn { get; set; }

                [NameInMap("AlertSrcProd")]
                [Validation(Required=false)]
                public string AlertSrcProd { get; set; }

                [NameInMap("AlertSrcProdModule")]
                [Validation(Required=false)]
                public string AlertSrcProdModule { get; set; }

                [NameInMap("AlertTitle")]
                [Validation(Required=false)]
                public string AlertTitle { get; set; }

                [NameInMap("AlertTitleEn")]
                [Validation(Required=false)]
                public string AlertTitleEn { get; set; }

                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                [NameInMap("AlertTypeCode")]
                [Validation(Required=false)]
                public string AlertTypeCode { get; set; }

                [NameInMap("AlertTypeEn")]
                [Validation(Required=false)]
                public string AlertTypeEn { get; set; }

                [NameInMap("AlertUuid")]
                [Validation(Required=false)]
                public string AlertUuid { get; set; }

                [NameInMap("AssetList")]
                [Validation(Required=false)]
                public string AssetList { get; set; }

                [NameInMap("AttCk")]
                [Validation(Required=false)]
                public string AttCk { get; set; }

                [NameInMap("CloudCode")]
                [Validation(Required=false)]
                public string CloudCode { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                [NameInMap("IsDefend")]
                [Validation(Required=false)]
                public string IsDefend { get; set; }

                [NameInMap("LogTime")]
                [Validation(Required=false)]
                public string LogTime { get; set; }

                [NameInMap("LogUuid")]
                [Validation(Required=false)]
                public string LogUuid { get; set; }

                [NameInMap("MainUserId")]
                [Validation(Required=false)]
                public long? MainUserId { get; set; }

                [NameInMap("OccurTime")]
                [Validation(Required=false)]
                public string OccurTime { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public long? SubUserId { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
