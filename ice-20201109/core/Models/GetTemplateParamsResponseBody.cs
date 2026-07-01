// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetTemplateParamsResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried parameters.</para>
        /// </summary>
        [NameInMap("ParamList")]
        [Validation(Required=false)]
        public List<GetTemplateParamsResponseBodyParamList> ParamList { get; set; }
        public class GetTemplateParamsResponseBodyParamList : TeaModel {
            /// <summary>
            /// <para>The original subtitle content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Subtitle test</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The thumbnail URL of the original material.</para>
            /// </summary>
            [NameInMap("CoverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            /// <summary>
            /// <para>The height of the original material in the output video, in absolute pixel values. This value is returned only for standard templates created in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>video1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The URL of the original material.</para>
            /// </summary>
            [NameInMap("MediaUrl")]
            [Validation(Required=false)]
            public string MediaUrl { get; set; }

            /// <summary>
            /// <para>In-point of the original material segment relative to the timeline, in seconds. This value is returned only for standard templates created in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.5</para>
            /// </summary>
            [NameInMap("TimelineIn")]
            [Validation(Required=false)]
            public float? TimelineIn { get; set; }

            /// <summary>
            /// <para>Out-point of the original material segment relative to the timeline, in seconds. This value is returned only for standard templates created in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.5</para>
            /// </summary>
            [NameInMap("TimelineOut")]
            [Validation(Required=false)]
            public float? TimelineOut { get; set; }

            /// <summary>
            /// <para>The material type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Video</para>
            /// </description></item>
            /// <item><description><para>Text</para>
            /// </description></item>
            /// <item><description><para>Image</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Image</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The width of the original material in the output video, in absolute pixel values. This value is returned only for standard templates created in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

            /// <summary>
            /// <para>The horizontal distance of the original material relative to the top-left corner of the video, in absolute pixel values. This value is returned only for standard templates created in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public int? X { get; set; }

            /// <summary>
            /// <para>The vertical distance of the original material relative to the top-left corner of the video, in absolute pixel values. This value is returned only for standard templates created in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public int? Y { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>2876-6263-4B75-8F2C-CD0F7FCF</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>419c8741c1b4325f035b</b></b></b></para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
