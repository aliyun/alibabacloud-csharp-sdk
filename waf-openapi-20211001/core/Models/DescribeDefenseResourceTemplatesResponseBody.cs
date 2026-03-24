// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseResourceTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2305CEB0-BA5A-5543-A1D3-3F1D08911B1C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The protection templates.</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeDefenseResourceTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeDefenseResourceTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// <para>The protection scenario. For more information, see the <b>DefenseScene</b> parameter in <a href="https://help.aliyun.com/document_detail/461421.html">CreateDefenseRule</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>whitelist</para>
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// <para>The sub-scenario of the template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>web</b>: The bot management template for web protection.</para>
            /// </description></item>
            /// <item><description><para><b>app</b>: The bot management template for app protection.</para>
            /// </description></item>
            /// <item><description><para><b>basic</b>: The basic bot management template.</para>
            /// </description></item>
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
            /// <para>The time when the protection template was created, in UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1692930539000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the protection template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34328</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the protection template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>antiscanTemplate</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The origin of the protection template. The value custom indicates a user-created template.</para>
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
            /// <item><description><para><b>0</b>: Disabled.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TemplateStatus")]
            [Validation(Required=false)]
            public int? TemplateStatus { get; set; }

            /// <summary>
            /// <para>The type of the template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>user_default</b>: The default template for the user.</para>
            /// </description></item>
            /// <item><description><para><b>user_custom</b>: A custom template created by the user.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user_custom</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

    }

}
