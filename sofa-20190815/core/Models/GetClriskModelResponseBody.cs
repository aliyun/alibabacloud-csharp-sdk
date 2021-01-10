// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetClriskModelResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("CurrentOwner")]
        [Validation(Required=false)]
        public bool? CurrentOwner { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        [NameInMap("ModelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TemplateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        [NameInMap("TriggerDelay")]
        [Validation(Required=false)]
        public string TriggerDelay { get; set; }

        [NameInMap("TriggerMode")]
        [Validation(Required=false)]
        public string TriggerMode { get; set; }

        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("DataNodes")]
        [Validation(Required=false)]
        public List<GetClriskModelResponseBodyDataNodes> DataNodes { get; set; }
        public class GetClriskModelResponseBodyDataNodes : TeaModel {
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

        [NameInMap("ExtMap")]
        [Validation(Required=false)]
        public List<GetClriskModelResponseBodyExtMap> ExtMap { get; set; }
        public class GetClriskModelResponseBodyExtMap : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Owners")]
        [Validation(Required=false)]
        public List<GetClriskModelResponseBodyOwners> Owners { get; set; }
        public class GetClriskModelResponseBodyOwners : TeaModel {
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

        [NameInMap("Subscribers")]
        [Validation(Required=false)]
        public List<GetClriskModelResponseBodySubscribers> Subscribers { get; set; }
        public class GetClriskModelResponseBodySubscribers : TeaModel {
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

        [NameInMap("LastModifier")]
        [Validation(Required=false)]
        public GetClriskModelResponseBodyLastModifier LastModifier { get; set; }
        public class GetClriskModelResponseBodyLastModifier : TeaModel {
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
        };

        [NameInMap("ModifiedColumn")]
        [Validation(Required=false)]
        public GetClriskModelResponseBodyModifiedColumn ModifiedColumn { get; set; }
        public class GetClriskModelResponseBodyModifiedColumn : TeaModel {
            [NameInMap("ModelConfig")]
            [Validation(Required=false)]
            public bool? ModelConfig { get; set; }
            [NameInMap("RuleCodes")]
            [Validation(Required=false)]
            public List<GetClriskModelResponseBodyModifiedColumnRuleCodes> RuleCodes { get; set; }
            public class GetClriskModelResponseBodyModifiedColumnRuleCodes : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
