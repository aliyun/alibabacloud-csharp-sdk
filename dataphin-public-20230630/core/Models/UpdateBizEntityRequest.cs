// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpdateBizEntityRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The update request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpdateCommand")]
        [Validation(Required=false)]
        public UpdateBizEntityRequestUpdateCommand UpdateCommand { get; set; }
        public class UpdateBizEntityRequestUpdateCommand : TeaModel {
            /// <summary>
            /// <para>The business object.</para>
            /// </summary>
            [NameInMap("BizObject")]
            [Validation(Required=false)]
            public UpdateBizEntityRequestUpdateCommandBizObject BizObject { get; set; }
            public class UpdateBizEntityRequestUpdateCommandBizObject : TeaModel {
                /// <summary>
                /// <para>The description of the business object. The description can be up to 128 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name of the business object. The name can be up to 64 characters in length and can contain only Chinese characters, letters, digits, underscores, and hyphens.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>create_object_name</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The code name of the business object. The name can be up to 64 characters in length and can contain only letters, digits, and underscores. For the ADB_PG engine, the code name can be up to 40 characters in length.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>create_object_code_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The user ID of the business object owner.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30010010</para>
                /// </summary>
                [NameInMap("OwnerUserId")]
                [Validation(Required=false)]
                public string OwnerUserId { get; set; }

                /// <summary>
                /// <para>The inherited entity of the business object. Only common business objects support inherited entity configuration, and only online business objects can be inherited.</para>
                /// 
                /// <b>Example:</b>
                /// <para>116306</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                /// <summary>
                /// <para>The list of associated online business entity IDs. If this parameter is not specified, the existing values are cleared.</para>
                /// </summary>
                [NameInMap("RefBizEntityIdList")]
                [Validation(Required=false)]
                public List<long?> RefBizEntityIdList { get; set; }

            }

            /// <summary>
            /// <para>The business process.</para>
            /// </summary>
            [NameInMap("BizProcess")]
            [Validation(Required=false)]
            public UpdateBizEntityRequestUpdateCommandBizProcess BizProcess { get; set; }
            public class UpdateBizEntityRequestUpdateCommandBizProcess : TeaModel {
                /// <summary>
                /// <para>The list of business event activity IDs contained in the business flow activity. This parameter is valid only when the current entity is a business flow activity.</para>
                /// </summary>
                [NameInMap("BizEventEntityIdList")]
                [Validation(Required=false)]
                public List<long?> BizEventEntityIdList { get; set; }

                /// <summary>
                /// <para>The description of the business process. The description can be up to 128 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name of the business process. The name can be up to 64 characters in length and can contain only Chinese characters, letters, digits, underscores, and hyphens.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>create_process_name</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The code name of the business process. The name can be up to 64 characters in length and can contain only letters, digits, and underscores. For the ADB_PG engine, the code name can be up to 40 characters in length.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>create_process_code_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The user ID of the business process owner.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30010010</para>
                /// </summary>
                [NameInMap("OwnerUserId")]
                [Validation(Required=false)]
                public string OwnerUserId { get; set; }

                /// <summary>
                /// <para>The preceding business flow activities of the business flow activity.</para>
                /// </summary>
                [NameInMap("PreBizProcessIdList")]
                [Validation(Required=false)]
                public List<long?> PreBizProcessIdList { get; set; }

                /// <summary>
                /// <para>The list of associated online business entity IDs. If this parameter is not specified, the existing values are cleared.</para>
                /// </summary>
                [NameInMap("RefBizEntityIdList")]
                [Validation(Required=false)]
                public List<long?> RefBizEntityIdList { get; set; }

            }

            /// <summary>
            /// <para>The ID of the business unit to which the business process belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6798087749072704</para>
            /// </summary>
            [NameInMap("BizUnitId")]
            [Validation(Required=false)]
            public long? BizUnitId { get; set; }

            /// <summary>
            /// <para>The ID of the data domain to which the business process belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20101011</para>
            /// </summary>
            [NameInMap("DataDomainId")]
            [Validation(Required=false)]
            public long? DataDomainId { get; set; }

            /// <summary>
            /// <para>The ID of the business entity.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101001201</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The type of the business entity. For more information, refer to the create business entity operation.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BIZ_OBJECT</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
