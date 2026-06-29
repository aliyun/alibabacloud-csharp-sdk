// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateBizEntityRequest : TeaModel {
        /// <summary>
        /// <para>The create request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateBizEntityRequestCreateCommand CreateCommand { get; set; }
        public class CreateBizEntityRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The business object.</para>
            /// </summary>
            [NameInMap("BizObject")]
            [Validation(Required=false)]
            public CreateBizEntityRequestCreateCommandBizObject BizObject { get; set; }
            public class CreateBizEntityRequestCreateCommandBizObject : TeaModel {
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
                /// <para>The code name of the business object. The name can be up to 64 characters in length and can contain only letters, digits, and underscores. For ADB_PG engines, the code name can be up to 40 characters in length.</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>30010010</para>
                /// </summary>
                [NameInMap("OwnerUserId")]
                [Validation(Required=false)]
                public string OwnerUserId { get; set; }

                /// <summary>
                /// <para>The parent entity from which the business object inherits. Only common business objects support inheritance, and the parent entity must be an online business object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>116306</para>
                /// </summary>
                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public long? ParentId { get; set; }

                /// <summary>
                /// <para>The list of associated online business entity IDs.</para>
                /// </summary>
                [NameInMap("RefBizEntityIdList")]
                [Validation(Required=false)]
                public List<long?> RefBizEntityIdList { get; set; }

                /// <summary>
                /// <para>The object type of the business object. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL: common object.</description></item>
                /// <item><description>ENUM: enumeration object.</description></item>
                /// <item><description>VIRTUAL: virtual object.</description></item>
                /// <item><description>HIERARCHY: hierarchy object.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The business activity.</para>
            /// </summary>
            [NameInMap("BizProcess")]
            [Validation(Required=false)]
            public CreateBizEntityRequestCreateCommandBizProcess BizProcess { get; set; }
            public class CreateBizEntityRequestCreateCommandBizProcess : TeaModel {
                /// <summary>
                /// <para>The list of business event activity IDs included in the business process activity. This parameter takes effect only when the current activity is a business process activity.</para>
                /// </summary>
                [NameInMap("BizEventEntityIdList")]
                [Validation(Required=false)]
                public List<long?> BizEventEntityIdList { get; set; }

                /// <summary>
                /// <para>The description of the business activity. The description can be up to 128 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name of the business activity. The name can be up to 64 characters in length and can contain only Chinese characters, letters, digits, underscores, and hyphens.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>create_process_name</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The code name of the business activity. The name can be up to 64 characters in length and can contain only letters, digits, and underscores. For ADB_PG engines, the code name can be up to 40 characters in length.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>create_process_code_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The user ID of the business activity owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30010010</para>
                /// </summary>
                [NameInMap("OwnerUserId")]
                [Validation(Required=false)]
                public string OwnerUserId { get; set; }

                /// <summary>
                /// <para>The list of preceding business process activity IDs for the business process activity.</para>
                /// </summary>
                [NameInMap("PreBizProcessIdList")]
                [Validation(Required=false)]
                public List<long?> PreBizProcessIdList { get; set; }

                /// <summary>
                /// <para>The list of associated online business entity IDs.</para>
                /// </summary>
                [NameInMap("RefBizEntityIdList")]
                [Validation(Required=false)]
                public List<long?> RefBizEntityIdList { get; set; }

                /// <summary>
                /// <para>The type of the business activity. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BIZ_EVENT: business event.</description></item>
                /// <item><description>BIZ_SNAPSHOT: business snapshot.</description></item>
                /// <item><description>BIZ_PROCESS: business process.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BIZ_EVENT</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The ID of the business unit to which the business activity belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6798087749072704</para>
            /// </summary>
            [NameInMap("BizUnitId")]
            [Validation(Required=false)]
            public long? BizUnitId { get; set; }

            /// <summary>
            /// <para>The ID of the data domain to which the business activity belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20101011</para>
            /// </summary>
            [NameInMap("DataDomainId")]
            [Validation(Required=false)]
            public long? DataDomainId { get; set; }

            /// <summary>
            /// <para>The business type. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>BIZ_OBJECT: business object.</description></item>
            /// <item><description>BIZ_PROCESS: business activity.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BIZ_OBJECT</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

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

    }

}
