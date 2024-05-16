// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgDesensPlanQueryListResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("PageData")]
        [Validation(Required=false)]
        public DsgDesensPlanQueryListResponseBodyPageData PageData { get; set; }
        public class DsgDesensPlanQueryListResponseBodyPageData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<DsgDesensPlanQueryListResponseBodyPageDataData> Data { get; set; }
            public class DsgDesensPlanQueryListResponseBodyPageDataData : TeaModel {
                [NameInMap("CheckWatermark")]
                [Validation(Required=false)]
                public bool? CheckWatermark { get; set; }

                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("DesenMode")]
                [Validation(Required=false)]
                public string DesenMode { get; set; }

                [NameInMap("DesensPlan")]
                [Validation(Required=false)]
                public DsgDesensPlanQueryListResponseBodyPageDataDataDesensPlan DesensPlan { get; set; }
                public class DsgDesensPlanQueryListResponseBodyPageDataDataDesensPlan : TeaModel {
                    [NameInMap("DesensPlanType")]
                    [Validation(Required=false)]
                    public string DesensPlanType { get; set; }

                    [NameInMap("ExtParam")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtParam { get; set; }

                }

                [NameInMap("DesensRule")]
                [Validation(Required=false)]
                public string DesensRule { get; set; }

                [NameInMap("DesensWay")]
                [Validation(Required=false)]
                public string DesensWay { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("SceneCode")]
                [Validation(Required=false)]
                public string SceneCode { get; set; }

                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
