// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetTemplateParamsResponseBody : TeaModel {
        /// <summary>
        /// <para>The parameter list.</para>
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
            /// <para>The thumbnail URL of the original media.</para>
            /// </summary>
            [NameInMap("CoverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            /// <summary>
            /// <para>The height of the original media in the output video, in absolute pixel values. Currently, this value is returned only for common templates created in the console.</para>
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
            /// <para>The URL of the original media.</para>
            /// </summary>
            [NameInMap("MediaUrl")]
            [Validation(Required=false)]
            public string MediaUrl { get; set; }

            /// <summary>
            /// <para>The in-point of the original media clip relative to the timeline. Unit: seconds. Currently, this value is returned only for common templates created in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.5</para>
            /// </summary>
            [NameInMap("TimelineIn")]
            [Validation(Required=false)]
            public float? TimelineIn { get; set; }

            /// <summary>
            /// <para>The out-point of the original media clip relative to the timeline. Unit: seconds. Currently, this value is returned only for common templates created in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.5</para>
            /// </summary>
            [NameInMap("TimelineOut")]
            [Validation(Required=false)]
            public float? TimelineOut { get; set; }

            /// <summary>
            /// <para>The media type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Image</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The width of the original media in the output video, in absolute pixel values. Currently, this value is returned only for common templates created in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

            /// <summary>
            /// <para>The horizontal distance of the original media from the upper-left corner of the video, in absolute pixel values. Currently, this value is returned only for common templates created in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("X")]
            [Validation(Required=false)]
            public int? X { get; set; }

            /// <summary>
            /// <para>The vertical distance of the original media from the upper-left corner of the video, in absolute pixel values. Currently, this value is returned only for common templates created in the console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Y")]
            [Validation(Required=false)]
            public int? Y { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
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
