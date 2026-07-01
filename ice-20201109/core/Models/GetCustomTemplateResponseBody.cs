// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetCustomTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The template details.</para>
        /// </summary>
        [NameInMap("CustomTemplate")]
        [Validation(Required=false)]
        public GetCustomTemplateResponseBodyCustomTemplate CustomTemplate { get; set; }
        public class GetCustomTemplateResponseBodyCustomTemplate : TeaModel {
            /// <summary>
            /// <para>The time when the template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-01T10:00:00Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Reserved for frontend display.</para>
            /// </summary>
            [NameInMap("FrontendHint")]
            [Validation(Required=false)]
            public GetCustomTemplateResponseBodyCustomTemplateFrontendHint FrontendHint { get; set; }
            public class GetCustomTemplateResponseBodyCustomTemplateFrontendHint : TeaModel {
                /// <summary>
                /// <para>Hint for transcoding templates.</para>
                /// </summary>
                [NameInMap("TranscodeTemplateHint")]
                [Validation(Required=false)]
                public GetCustomTemplateResponseBodyCustomTemplateFrontendHintTranscodeTemplateHint TranscodeTemplateHint { get; set; }
                public class GetCustomTemplateResponseBodyCustomTemplateFrontendHintTranscodeTemplateHint : TeaModel {
                    /// <summary>
                    /// <para>The bitrate control type.</para>
                    /// </summary>
                    [NameInMap("BitrateControlType")]
                    [Validation(Required=false)]
                    public string BitrateControlType { get; set; }

                }

            }

            /// <summary>
            /// <para>Indicates whether the template is a default template.</para>
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
            /// <para>2022-01-01T11:00:00Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

            /// <summary>
            /// <para>The status of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the template subtype.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Subtype")]
            [Validation(Required=false)]
            public int? Subtype { get; set; }

            /// <summary>
            /// <para>The name of the template subtype.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("SubtypeName")]
            [Validation(Required=false)]
            public string SubtypeName { get; set; }

            /// <summary>
            /// <para>The template configuration, in a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Type&quot;:&quot;Normal&quot;,&quot;FrameType&quot;:&quot;normal&quot;,&quot;Time&quot;:0,&quot;Count&quot;:10}</para>
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
            /// <para>Test screenshot template</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>The ID of the template type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The name of the template type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SnapshotTemplate</para>
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

    }

}
