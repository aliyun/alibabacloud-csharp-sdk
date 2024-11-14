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
        /// <para>4F26D2F1-E288-5104-8518-05E240E3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The protection templates.</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeDefenseTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeDefenseTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// <para>The scenario in which the protection template is used.</para>
            /// <list type="bullet">
            /// <item><description><b>waf_group</b>: basic protection.</description></item>
            /// <item><description><b>antiscan</b>: scan protection.</description></item>
            /// <item><description><b>ip_blacklist</b>: IP address blacklist.</description></item>
            /// <item><description><b>custom_acl</b>: custom rule.</description></item>
            /// <item><description><b>whitelist</b>: whitelist.</description></item>
            /// <item><description><b>region_block</b>: region blacklist.</description></item>
            /// <item><description><b>custom_response</b>: custom response.</description></item>
            /// <item><description><b>cc</b>: HTTP flood protection.</description></item>
            /// <item><description><b>tamperproof</b>: website tamper-proofing.</description></item>
            /// <item><description><b>dlp</b>: data leakage prevention.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>whitelist</para>
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// <para>The sub-scenario in which the protection template is used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>web</b>: bot management for website protection.</description></item>
            /// <item><description><b>app</b>: bot management for app protection.</description></item>
            /// <item><description><b>basic</b>: bot management for basic protection.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>basic</para>
            /// </summary>
            [NameInMap("DefenseSubScene")]
            [Validation(Required=false)]
            public string DefenseSubScene { get; set; }

            /// <summary>
            /// <para>The description of the protection template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the protection template was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
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
            /// <para>12345</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the protection template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testTemplateName</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The origin of the protection template. The value custom indicates that the protection template is a custom template created by the user.</para>
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
            /// <para>The type of the protection template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>user_default</b>: default template.</description></item>
            /// <item><description><b>user_custom</b>: custom template.</description></item>
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
