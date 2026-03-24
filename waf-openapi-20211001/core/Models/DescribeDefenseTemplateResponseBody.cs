// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19160D5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the protection template.</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public DescribeDefenseTemplateResponseBodyTemplate Template { get; set; }
        public class DescribeDefenseTemplateResponseBodyTemplate : TeaModel {
            /// <summary>
            /// <para>The scenario in which the protection template is used. For more information, see the description of the <b>DefenseScene</b> parameter in the <a href="~~CreateDefenseRule~~">CreateDefenseRule</a> operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>waf_group</para>
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// <para>The sub-scenario of the protection template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>web</b>: the bot management template for website protection.</para>
            /// </description></item>
            /// <item><description><para><b>app</b>: the bot management template for app protection.</para>
            /// </description></item>
            /// <item><description><para><b>basic</b>: the basic bot management template.</para>
            /// </description></item>
            /// <item><description><para><b>bot_custom_acl</b>: the bot management template for custom protection rules.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>app</para>
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
            /// <para>The most recent time the protection template was modified. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665283642000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the protection template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10097</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the protection template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test0621</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The origin of the protection template. A value of <b>custom</b> indicates that the template is user-defined.</para>
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
            /// <item><description><para><b>0</b>: disabled.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: enabled.</para>
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
            /// <para>The type of the protection template. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>user_default</b>: the default template.</para>
            /// </description></item>
            /// <item><description><para><b>user_custom</b>: a custom template.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user_default</para>
            /// </summary>
            [NameInMap("TemplateType")]
            [Validation(Required=false)]
            public string TemplateType { get; set; }

        }

    }

}
