// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListCustomTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried templates.</para>
        /// </summary>
        [NameInMap("CustomTemplateList")]
        [Validation(Required=false)]
        public List<ListCustomTemplatesResponseBodyCustomTemplateList> CustomTemplateList { get; set; }
        public class ListCustomTemplatesResponseBodyCustomTemplateList : TeaModel {
            /// <summary>
            /// <para>The time when the template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-12T16:17:54Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("FrontendHint")]
            [Validation(Required=false)]
            public ListCustomTemplatesResponseBodyCustomTemplateListFrontendHint FrontendHint { get; set; }
            public class ListCustomTemplatesResponseBodyCustomTemplateListFrontendHint : TeaModel {
                [NameInMap("TranscodeTemplateHint")]
                [Validation(Required=false)]
                public ListCustomTemplatesResponseBodyCustomTemplateListFrontendHintTranscodeTemplateHint TranscodeTemplateHint { get; set; }
                public class ListCustomTemplatesResponseBodyCustomTemplateListFrontendHintTranscodeTemplateHint : TeaModel {
                    [NameInMap("BitrateControlType")]
                    [Validation(Required=false)]
                    public string BitrateControlType { get; set; }

                }

            }

            /// <summary>
            /// <para>Indicates whether the template is the default template.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The time when the template was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-12T16:17:54Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The template state.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The subtype ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Subtype")]
            [Validation(Required=false)]
            public int? Subtype { get; set; }

            /// <summary>
            /// <para>The subtype name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AudioTranscode</para>
            /// </summary>
            [NameInMap("SubtypeName")]
            [Validation(Required=false)]
            public string SubtypeName { get; set; }

            /// <summary>
            /// <para>The template parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Container&quot;:{&quot;Format&quot;:&quot;mp3&quot;},&quot;Audio&quot;:{&quot;Codec&quot;:&quot;mp3&quot;,&quot;Bitrate&quot;:&quot;64&quot;,&quot;Samplerate&quot;:&quot;22050&quot;,&quot;Channels&quot;:&quot;2&quot;}}</para>
            /// </summary>
            [NameInMap("TemplateConfig")]
            [Validation(Required=false)]
            public string TemplateConfig { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-template</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The type ID of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The type name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TranscodeTemplate</para>
            /// </summary>
            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
