// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListClriskModelsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("EntranceList")]
        [Validation(Required=false)]
        public List<ListClriskModelsResponseBodyEntranceList> EntranceList { get; set; }
        public class ListClriskModelsResponseBodyEntranceList : TeaModel {
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

            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TriggerDelay")]
            [Validation(Required=false)]
            public string TriggerDelay { get; set; }

            [NameInMap("TriggerMode")]
            [Validation(Required=false)]
            public string TriggerMode { get; set; }

            [NameInMap("DataNodes")]
            [Validation(Required=false)]
            public List<ListClriskModelsResponseBodyEntranceListDataNodes> DataNodes { get; set; }
            public class ListClriskModelsResponseBodyEntranceListDataNodes : TeaModel {
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

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                [NameInMap("UpdateUser")]
                [Validation(Required=false)]
                public string UpdateUser { get; set; }

            }

            [NameInMap("ExtMap")]
            [Validation(Required=false)]
            public List<ListClriskModelsResponseBodyEntranceListExtMap> ExtMap { get; set; }
            public class ListClriskModelsResponseBodyEntranceListExtMap : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Owners")]
            [Validation(Required=false)]
            public List<ListClriskModelsResponseBodyEntranceListOwners> Owners { get; set; }
            public class ListClriskModelsResponseBodyEntranceListOwners : TeaModel {
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
            public ListClriskModelsResponseBodyEntranceListLastModifier LastModifier { get; set; }
            public class ListClriskModelsResponseBodyEntranceListLastModifier : TeaModel {
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
            public ListClriskModelsResponseBodyEntranceListModifiedColumn ModifiedColumn { get; set; }
            public class ListClriskModelsResponseBodyEntranceListModifiedColumn : TeaModel {
                [NameInMap("ModelConfig")]
                [Validation(Required=false)]
                public bool? ModelConfig { get; set; }
                [NameInMap("RuleCodes")]
                [Validation(Required=false)]
                public List<ListClriskModelsResponseBodyEntranceListModifiedColumnRuleCodes> RuleCodes { get; set; }
                public class ListClriskModelsResponseBodyEntranceListModifiedColumnRuleCodes : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
            };

        }

    }

}
