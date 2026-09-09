// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F26D2F1-E288-5104-8518-05E240E337A4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of protection templates.</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeDefenseTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeDefenseTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// <para>The WAF protection scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>waf_group</b>: basic protection.</para>
            /// </description></item>
            /// <item><description><para><b>antiscan</b>: scan protection.</para>
            /// </description></item>
            /// <item><description><para><b>ip_blacklist</b>: IP blacklist.</para>
            /// </description></item>
            /// <item><description><para><b>custom_acl</b>: custom rule.</para>
            /// </description></item>
            /// <item><description><para><b>whitelist</b>: whitelist.</para>
            /// </description></item>
            /// <item><description><para><b>region_block</b>: location blacklist.</para>
            /// </description></item>
            /// <item><description><para><b>custom_response</b>: custom response.</para>
            /// </description></item>
            /// <item><description><para><b>cc</b>: HTTP flood mitigation.</para>
            /// </description></item>
            /// <item><description><para><b>tamperproof</b>: web tamper proofing.</para>
            /// </description></item>
            /// <item><description><para><b>dlp</b>: data leak prevention.</para>
            /// </description></item>
            /// <item><description><para><b>bot_manager</b>: new bot management.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>whitelist</para>
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// <para>The sub-scenario of the protection template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>web</b>: bot management web protection scenario template.</description></item>
            /// <item><description><b>app</b>: bot management app protection scenario template.</description></item>
            /// <item><description><b>basic</b>: bot management basic protection template.</description></item>
            /// <item><description><b>bot_custom_acl</b>: bot management advanced custom rule protection template.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("DefenseSubScene")]
            [Validation(Required=false)]
            public string DefenseSubScene { get; set; }

            /// <summary>
            /// <para>The description of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testTemplate</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The detailed template information. For more information, see the Detail parameter in <a href="https://help.aliyun.com/document_detail/461613.html">CreateDefenseTemplate</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;trafficFeature&quot;:&quot;{\&quot;global\&quot;:0,\&quot;excludeStatus\&quot;:1,\&quot;conditions\&quot;:[{\&quot;key\&quot;:\&quot;URL\&quot;,\&quot;opValue\&quot;:\&quot;not-contain\&quot;,\&quot;values\&quot;:\&quot;test\&quot;}]}&quot;}</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public Dictionary<string, object> Detail { get; set; }

            /// <summary>
            /// <para>The time when the protection template was created. The value is a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683776070000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the protection template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>56477</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the protection template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>template-blockarea1</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The source of the protection template. The value custom indicates that the template is user-defined.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("TemplateOrigin")]
            [Validation(Required=false)]
            public string TemplateOrigin { get; set; }

            /// <summary>
            /// <para>The status of the protection template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled.</description></item>
            /// <item><description><b>1</b>: enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TemplateStatus")]
            [Validation(Required=false)]
            public int? TemplateStatus { get; set; }

            /// <summary>
            /// <para>The templatetype of the protection template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>user_default</b>: default protection.</description></item>
            /// <item><description><b>user_custom</b>: custom protection.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user_custom</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
