// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateSecurityStrategyRequest : TeaModel {
        /// <summary>
        /// <para>A client token to ensure request idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AFAE64E-D1BE-432B-A9*****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The policy content, which is constrained by the <c>SecurityStrategySchema</c>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public UpdateSecurityStrategyRequestContent Content { get; set; }
        public class UpdateSecurityStrategyRequestContent : TeaModel {
            /// <summary>
            /// <para>A list of controllers.</para>
            /// <para>Note: The valid controllers depend on the selected schema. For more information, see the controller definition and the list of controllers for each schema.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Controllers")]
            [Validation(Required=false)]
            public List<UpdateSecurityStrategyRequestContentControllers> Controllers { get; set; }
            public class UpdateSecurityStrategyRequestContentControllers : TeaModel {
                /// <summary>
                /// <para>The default value for the Basic edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("BasicEditionDefaultValue")]
                [Validation(Required=false)]
                public object BasicEditionDefaultValue { get; set; }

                /// <summary>
                /// <para>The value range for the Basic edition, specified as <c>[min, max]</c>.</para>
                /// </summary>
                [NameInMap("BasicEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> BasicEditionIntervalValue { get; set; }

                /// <summary>
                /// <para>The controller identifier. For valid values, see the list of controllers for each schema.</para>
                /// 
                /// <b>Example:</b>
                /// <para>viewCount</para>
                /// </summary>
                [NameInMap("Controller")]
                [Validation(Required=false)]
                public string Controller { get; set; }

                /// <summary>
                /// <para>The data type of the controller\&quot;s value. Valid values: <c>Boolean</c>, <c>Integer</c>, <c>Long</c>, and <c>String</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Integer</para>
                /// </summary>
                [NameInMap("ControllerValueType")]
                [Validation(Required=false)]
                public string ControllerValueType { get; set; }

                /// <summary>
                /// <para>The display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>查询结果-单次展示记录值上限</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The English display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Query Results - Single Display Record Limit</para>
                /// </summary>
                [NameInMap("DisplayNameEn")]
                [Validation(Required=false)]
                public string DisplayNameEn { get; set; }

                /// <summary>
                /// <para>Indicates whether the controller is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The default value for the Enterprise edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("EnterpriseEditionDefaultValue")]
                [Validation(Required=false)]
                public object EnterpriseEditionDefaultValue { get; set; }

                /// <summary>
                /// <para>The value range for the Enterprise edition, specified as <c>[min, max]</c>.</para>
                /// </summary>
                [NameInMap("EnterpriseEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> EnterpriseEditionIntervalValue { get; set; }

                /// <summary>
                /// <para>The default value for the Professional edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("ProfessionalEditionDefaultValue")]
                [Validation(Required=false)]
                public object ProfessionalEditionDefaultValue { get; set; }

                /// <summary>
                /// <para>The value range for the Professional edition, specified as <c>[min, max]</c>.</para>
                /// </summary>
                [NameInMap("ProfessionalEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> ProfessionalEditionIntervalValue { get; set; }

                /// <summary>
                /// <para>The default value for the Standard edition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("StandardEditionDefaultValue")]
                [Validation(Required=false)]
                public object StandardEditionDefaultValue { get; set; }

                /// <summary>
                /// <para>The value range for the Standard edition, specified as <c>[min, max]</c>.</para>
                /// </summary>
                [NameInMap("StandardEditionIntervalValue")]
                [Validation(Required=false)]
                public List<int?> StandardEditionIntervalValue { get; set; }

                /// <summary>
                /// <para>The user-configured value. The type of this value is determined by the <c>ControllerValueType</c> parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("UserConfigValue")]
                [Validation(Required=false)]
                public object UserConfigValue { get; set; }

            }

        }

        /// <summary>
        /// <para><b>The policy description.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>控制数据分析模块的查询结果安全行为</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para><b>The policy ID.</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para><b>The policy name.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>默认数据分析策略</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para><b>A list of associated workspace IDs.</b></para>
        /// </summary>
        [NameInMap("Workspaces")]
        [Validation(Required=false)]
        public List<long?> Workspaces { get; set; }

    }

}
