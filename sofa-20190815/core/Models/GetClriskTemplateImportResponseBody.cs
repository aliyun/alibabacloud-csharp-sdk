// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetClriskTemplateImportResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("TriggerDelay")]
        [Validation(Required=false)]
        public string TriggerDelay { get; set; }

        [NameInMap("TriggerMode")]
        [Validation(Required=false)]
        public string TriggerMode { get; set; }

        [NameInMap("DataNodes")]
        [Validation(Required=false)]
        public List<GetClriskTemplateImportResponseBodyDataNodes> DataNodes { get; set; }
        public class GetClriskTemplateImportResponseBodyDataNodes : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NodeCode")]
            [Validation(Required=false)]
            public string NodeCode { get; set; }

            [NameInMap("OdpsProject")]
            [Validation(Required=false)]
            public string OdpsProject { get; set; }

            [NameInMap("TableAuthDescription")]
            [Validation(Required=false)]
            public string TableAuthDescription { get; set; }

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("UpdateUser")]
            [Validation(Required=false)]
            public string UpdateUser { get; set; }

        }

        [NameInMap("Owners")]
        [Validation(Required=false)]
        public List<GetClriskTemplateImportResponseBodyOwners> Owners { get; set; }
        public class GetClriskTemplateImportResponseBodyOwners : TeaModel {
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("LoginName")]
            [Validation(Required=false)]
            public string LoginName { get; set; }

            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            [NameInMap("OriginId")]
            [Validation(Required=false)]
            public string OriginId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RuleList")]
        [Validation(Required=false)]
        public List<GetClriskTemplateImportResponseBodyRuleList> RuleList { get; set; }
        public class GetClriskTemplateImportResponseBodyRuleList : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("DebugStatus")]
            [Validation(Required=false)]
            public string DebugStatus { get; set; }

            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("RuleCode")]
            [Validation(Required=false)]
            public string RuleCode { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("TemplateCode")]
            [Validation(Required=false)]
            public string TemplateCode { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
