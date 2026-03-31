// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetRemediationTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the automatic remediation template.</para>
        /// </summary>
        [NameInMap("RemediationTemplates")]
        [Validation(Required=false)]
        public List<GetRemediationTemplateResponseBodyRemediationTemplates> RemediationTemplates { get; set; }
        public class GetRemediationTemplateResponseBodyRemediationTemplates : TeaModel {
            /// <summary>
            /// <para>The ID of the supported rule template.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-delete-protection-enabled</para>
            /// </summary>
            [NameInMap("ManagedRuleIdentifier")]
            [Validation(Required=false)]
            public string ManagedRuleIdentifier { get; set; }

            /// <summary>
            /// <para>The type of the automatic remediation template. The value is set to OOS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OOS</para>
            /// </summary>
            [NameInMap("RemediationType")]
            [Validation(Required=false)]
            public string RemediationType { get; set; }

            /// <summary>
            /// <para>The parameters of the automatic remediation template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;Parameters\&quot;:{\&quot;regionId\&quot;:{\&quot;AssociationProperty\&quot;:\&quot;RegionId\&quot;,\&quot;CreateDated\&quot;:\&quot;2023-09-08T16:36:15\&quot;,\&quot;Default\&quot;:\&quot;{regionId}\&quot;,\&quot;Description\&quot;:{\&quot;en\&quot;:\&quot;regionId\&quot;,\&quot;zh-cn\&quot;:\&quot;regionId\&quot;},\&quot;Id\&quot;:538,\&quot;MaxKeyLength\&quot;:\&quot;125\&quot;,\&quot;MaxValueLength\&quot;:\&quot;255\&quot;,\&quot;ModifiedDate\&quot;:\&quot;2023-09-08T16:36:15\&quot;,\&quot;Name\&quot;:\&quot;regionId\&quot;,\&quot;Optional\&quot;:1,\&quot;TemplateIdentifier\&quot;:\&quot;ACS-ALB-BulkyEnableDeletionProtection\&quot;,\&quot;Type\&quot;:\&quot;String\&quot;,\&quot;Version\&quot;:\&quot;LASTEST\&quot;},\&quot;loadBalancerIds\&quot;:{\&quot;CreateDated\&quot;:\&quot;2023-09-08T16:36:16\&quot;,\&quot;Default\&quot;:\&quot;[\\\&quot;{resourceId}\\\&quot;]\&quot;,\&quot;Description\&quot;:{\&quot;en\&quot;:\&quot;loadBalancerIds\&quot;,\&quot;zh-cn\&quot;:\&quot;loadBalancerIds\&quot;},\&quot;Id\&quot;:539,\&quot;MaxKeyLength\&quot;:\&quot;125\&quot;,\&quot;MaxValueLength\&quot;:\&quot;255\&quot;,\&quot;ModifiedDate\&quot;:\&quot;2023-09-08T16:36:16\&quot;,\&quot;Name\&quot;:\&quot;loadBalancerIds\&quot;,\&quot;Optional\&quot;:1,\&quot;TemplateIdentifier\&quot;:\&quot;ACS-ALB-BulkyEnableDeletionProtection\&quot;,\&quot;Type\&quot;:\&quot;ARRAY\&quot;,\&quot;Version\&quot;:\&quot;LASTEST\&quot;}}}</para>
            /// </summary>
            [NameInMap("TemplateDefinition")]
            [Validation(Required=false)]
            public string TemplateDefinition { get; set; }

            /// <summary>
            /// <para>The description of the automatic remediation template.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>调用接口EnableDeletionProtection，开启ALB实例删除保护，请您知晓风险谨慎操作。</para>
            /// </summary>
            [NameInMap("TemplateDescription")]
            [Validation(Required=false)]
            public string TemplateDescription { get; set; }

            /// <summary>
            /// <para>The ID of the automatic remediation template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS-ALB-BulkyEnableDeletionProtection</para>
            /// </summary>
            [NameInMap("TemplateIdentifier")]
            [Validation(Required=false)]
            public string TemplateIdentifier { get; set; }

            /// <summary>
            /// <para>The name of the automatic remediation template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>开启ALB实例删除保护</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E232FC35-BD40-51E3-B2EB-09416A234939</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
