// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetAuthorityTemplateItemResponseBody : TeaModel {
        /// <summary>
        /// The permission templates.
        /// </summary>
        [NameInMap("AuthorityTemplateItemList")]
        [Validation(Required=false)]
        public GetAuthorityTemplateItemResponseBodyAuthorityTemplateItemList AuthorityTemplateItemList { get; set; }
        public class GetAuthorityTemplateItemResponseBodyAuthorityTemplateItemList : TeaModel {
            [NameInMap("AuthorityTemplateItem")]
            [Validation(Required=false)]
            public List<GetAuthorityTemplateItemResponseBodyAuthorityTemplateItemListAuthorityTemplateItem> AuthorityTemplateItem { get; set; }
            public class GetAuthorityTemplateItemResponseBodyAuthorityTemplateItemListAuthorityTemplateItem : TeaModel {
                /// <summary>
                /// The additional information. For example, permissions to log on to an instance are added to the permission template.
                /// </summary>
                [NameInMap("Attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// The ID of the database.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// The ID of the resource.
                /// </summary>
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public long? ItemId { get; set; }

                /// <summary>
                /// The ID of the user who modifies the resource.
                /// </summary>
                [NameInMap("ModifierId")]
                [Validation(Required=false)]
                public long? ModifierId { get; set; }

                /// <summary>
                /// The type of the resource. Valid values:
                /// 
                /// *   **INSTANCE**: instance
                /// *   **LOGIC_DB**: logical database
                /// *   **META_DB**: physical database
                /// *   **LOGIC_TABLE**: logical table
                /// *   **LOGIC_TABLE**: physical table
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// The ID of the permission template.
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public long? TemplateId { get; set; }

            }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
