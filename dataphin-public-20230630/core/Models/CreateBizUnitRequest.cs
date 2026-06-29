// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CreateBizUnitRequest : TeaModel {
        /// <summary>
        /// <para>The create request.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CreateCommand")]
        [Validation(Required=false)]
        public CreateBizUnitRequestCreateCommand CreateCommand { get; set; }
        public class CreateBizUnitRequestCreateCommand : TeaModel {
            /// <summary>
            /// <para>The list of data domain architects.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("BizUnitAccountList")]
            [Validation(Required=false)]
            public List<CreateBizUnitRequestCreateCommandBizUnitAccountList> BizUnitAccountList { get; set; }
            public class CreateBizUnitRequestCreateCommandBizUnitAccountList : TeaModel {
                /// <summary>
                /// <para>The user ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20001201</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

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
            /// <para>The preset icon. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>icon-e-commerce: E-commerce.</description></item>
            /// <item><description>icon-finance: Finance.</description></item>
            /// <item><description>con-cloud-computing: Cloud computing.</description></item>
            /// <item><description>icon-advertisement: Advertising and marketing.</description></item>
            /// <item><description>icon-logistics: Logistics.</description></item>
            /// <item><description>icon-entertainment: Entertainment.</description></item>
            /// <item><description>icon-traffic: Travel.</description></item>
            /// <item><description>icon-health: Health.</description></item>
            /// <item><description>icon-social-contact: Social and communication.</description></item>
            /// <item><description>con-dining: Dining.</description></item>
            /// <item><description>icon-education: Education.</description></item>
            /// <item><description>icon-environment: Environment.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>icon-environment</para>
            /// </summary>
            [NameInMap("Icon")]
            [Validation(Required=false)]
            public string Icon { get; set; }

            /// <summary>
            /// <para>The production mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BASIC: single-environment mode.</description></item>
            /// <item><description>DEV_PROD: development/production dual-environment mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DEV_PROD</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

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
