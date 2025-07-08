// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class QueryWorkOrdAuditListNewResponseBody : TeaModel {
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryWorkOrdAuditListNewResponseBodyList> List { get; set; }
        public class QueryWorkOrdAuditListNewResponseBodyList : TeaModel {
            [NameInMap("AuditRemark")]
            [Validation(Required=false)]
            public string AuditRemark { get; set; }

            [NameInMap("AuditResult")]
            [Validation(Required=false)]
            public string AuditResult { get; set; }

            [NameInMap("BizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("OrdId")]
            [Validation(Required=false)]
            public string OrdId { get; set; }

            [NameInMap("OrdStatus")]
            [Validation(Required=false)]
            public string OrdStatus { get; set; }

            [NameInMap("Param")]
            [Validation(Required=false)]
            public QueryWorkOrdAuditListNewResponseBodyListParam Param { get; set; }
            public class QueryWorkOrdAuditListNewResponseBodyListParam : TeaModel {
                [NameInMap("AuditInfo")]
                [Validation(Required=false)]
                public string AuditInfo { get; set; }

                [NameInMap("AuditRemarkInfo")]
                [Validation(Required=false)]
                public QueryWorkOrdAuditListNewResponseBodyListParamAuditRemarkInfo AuditRemarkInfo { get; set; }
                public class QueryWorkOrdAuditListNewResponseBodyListParamAuditRemarkInfo : TeaModel {
                    [NameInMap("RejectDate")]
                    [Validation(Required=false)]
                    public string RejectDate { get; set; }

                    [NameInMap("RejectInfo")]
                    [Validation(Required=false)]
                    public string RejectInfo { get; set; }

                    [NameInMap("RejectSubInfo")]
                    [Validation(Required=false)]
                    public string RejectSubInfo { get; set; }

                }

                [NameInMap("AuditState")]
                [Validation(Required=false)]
                public QueryWorkOrdAuditListNewResponseBodyListParamAuditState AuditState { get; set; }
                public class QueryWorkOrdAuditListNewResponseBodyListParamAuditState : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public int? Value { get; set; }

                }

                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public int? BusinessType { get; set; }

                [NameInMap("ExtendMessage")]
                [Validation(Required=false)]
                public string ExtendMessage { get; set; }

                [NameInMap("FileIds")]
                [Validation(Required=false)]
                public List<long?> FileIds { get; set; }

                [NameInMap("FileUrlList")]
                [Validation(Required=false)]
                public List<string> FileUrlList { get; set; }

                [NameInMap("GmtCreateStr")]
                [Validation(Required=false)]
                public string GmtCreateStr { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("OrderId")]
                [Validation(Required=false)]
                public string OrderId { get; set; }

                [NameInMap("PartnerId")]
                [Validation(Required=false)]
                public long? PartnerId { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("SceneType")]
                [Validation(Required=false)]
                public int? SceneType { get; set; }

                [NameInMap("SignName")]
                [Validation(Required=false)]
                public string SignName { get; set; }

                [NameInMap("SignType")]
                [Validation(Required=false)]
                public int? SignType { get; set; }

            }

        }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
