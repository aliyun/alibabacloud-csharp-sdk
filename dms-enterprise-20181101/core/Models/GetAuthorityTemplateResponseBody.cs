// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetAuthorityTemplateResponseBody : TeaModel {
        /// <summary>
        /// The details of the permission template.
        /// </summary>
        [NameInMap("AuthorityTemplateView")]
        [Validation(Required=false)]
        public GetAuthorityTemplateResponseBodyAuthorityTemplateView AuthorityTemplateView { get; set; }
        public class GetAuthorityTemplateResponseBodyAuthorityTemplateView : TeaModel {
            /// <summary>
            /// The resource information in the permission template.
            /// </summary>
            [NameInMap("AuthorityTemplateItemList")]
            [Validation(Required=false)]
            public GetAuthorityTemplateResponseBodyAuthorityTemplateViewAuthorityTemplateItemList AuthorityTemplateItemList { get; set; }
            public class GetAuthorityTemplateResponseBodyAuthorityTemplateViewAuthorityTemplateItemList : TeaModel {
                [NameInMap("AuthorityTemplateItem")]
                [Validation(Required=false)]
                public List<GetAuthorityTemplateResponseBodyAuthorityTemplateViewAuthorityTemplateItemListAuthorityTemplateItem> AuthorityTemplateItem { get; set; }
                public class GetAuthorityTemplateResponseBodyAuthorityTemplateViewAuthorityTemplateItemListAuthorityTemplateItem : TeaModel {
                    /// <summary>
                    /// Other information. For example, you can add the logon permission on an instance to the permission template.
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
                    /// The ID of the user who modified the resource.
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
                    /// *   **SINGLE_TABLE**: physical table
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
            /// The time when the permission template was created. The time is in the yyyy-MM-DD HH:mm:ss format.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the user who created the permission template.
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }

            /// <summary>
            /// The description of the permission template.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the permission template.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The ID of the permission template.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
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
