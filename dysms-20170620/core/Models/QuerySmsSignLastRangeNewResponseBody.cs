// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QuerySmsSignLastRangeNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public QuerySmsSignLastRangeNewResponseBodyList List { get; set; }
        public class QuerySmsSignLastRangeNewResponseBodyList : TeaModel {
            [NameInMap("SmsSign")]
            [Validation(Required=false)]
            public List<QuerySmsSignLastRangeNewResponseBodyListSmsSign> SmsSign { get; set; }
            public class QuerySmsSignLastRangeNewResponseBodyListSmsSign : TeaModel {
                [NameInMap("AuditInfo")]
                [Validation(Required=false)]
                public string AuditInfo { get; set; }

                [NameInMap("AuditRemarkInfo")]
                [Validation(Required=false)]
                public string AuditRemarkInfo { get; set; }

                [NameInMap("AuditState")]
                [Validation(Required=false)]
                public string AuditState { get; set; }

                [NameInMap("ExtendMessage")]
                [Validation(Required=false)]
                public string ExtendMessage { get; set; }

                [NameInMap("FileIds")]
                [Validation(Required=false)]
                public QuerySmsSignLastRangeNewResponseBodyListSmsSignFileIds FileIds { get; set; }
                public class QuerySmsSignLastRangeNewResponseBodyListSmsSignFileIds : TeaModel {
                    [NameInMap("FileId")]
                    [Validation(Required=false)]
                    public List<long?> FileId { get; set; }

                }

                [NameInMap("FileUrlList")]
                [Validation(Required=false)]
                public QuerySmsSignLastRangeNewResponseBodyListSmsSignFileUrlList FileUrlList { get; set; }
                public class QuerySmsSignLastRangeNewResponseBodyListSmsSignFileUrlList : TeaModel {
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public List<string> FileUrl { get; set; }

                }

                [NameInMap("GmtCreateStr")]
                [Validation(Required=false)]
                public string GmtCreateStr { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("IsDefaultSign")]
                [Validation(Required=false)]
                public bool? IsDefaultSign { get; set; }

                [NameInMap("OperateDateStr")]
                [Validation(Required=false)]
                public string OperateDateStr { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("SceneType")]
                [Validation(Required=false)]
                public int? SceneType { get; set; }

                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public int? ServiceType { get; set; }

                [NameInMap("SignName")]
                [Validation(Required=false)]
                public string SignName { get; set; }

                [NameInMap("SignSceneDetailList")]
                [Validation(Required=false)]
                public QuerySmsSignLastRangeNewResponseBodyListSmsSignSignSceneDetailList SignSceneDetailList { get; set; }
                public class QuerySmsSignLastRangeNewResponseBodyListSmsSignSignSceneDetailList : TeaModel {
                    [NameInMap("SignSceneDetail")]
                    [Validation(Required=false)]
                    public List<QuerySmsSignLastRangeNewResponseBodyListSmsSignSignSceneDetailListSignSceneDetail> SignSceneDetail { get; set; }
                    public class QuerySmsSignLastRangeNewResponseBodyListSmsSignSignSceneDetailListSignSceneDetail : TeaModel {
                        [NameInMap("AuditState")]
                        [Validation(Required=false)]
                        public string AuditState { get; set; }

                        [NameInMap("SceneType")]
                        [Validation(Required=false)]
                        public int? SceneType { get; set; }

                    }

                }

                [NameInMap("SignType")]
                [Validation(Required=false)]
                public int? SignType { get; set; }

                [NameInMap("SignUsageName")]
                [Validation(Required=false)]
                public string SignUsageName { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
