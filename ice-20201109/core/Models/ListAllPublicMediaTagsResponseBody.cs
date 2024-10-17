// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListAllPublicMediaTagsResponseBody : TeaModel {
        /// <summary>
        /// <para>The tags of media assets in the public media library.</para>
        /// </summary>
        [NameInMap("MediaTagList")]
        [Validation(Required=false)]
        public List<ListAllPublicMediaTagsResponseBodyMediaTagList> MediaTagList { get; set; }
        public class ListAllPublicMediaTagsResponseBodyMediaTagList : TeaModel {
            /// <summary>
            /// <para>The ID of the media tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sticker-gif</para>
            /// </summary>
            [NameInMap("MediaTagId")]
            [Validation(Required=false)]
            public string MediaTagId { get; set; }

            /// <summary>
            /// <para>The name of the media tag in Chinese.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Gif</para>
            /// </summary>
            [NameInMap("MediaTagNameChinese")]
            [Validation(Required=false)]
            public string MediaTagNameChinese { get; set; }

            /// <summary>
            /// <para>The name of the material tag in English.</para>
            /// </summary>
            [NameInMap("MediaTagNameEnglish")]
            [Validation(Required=false)]
            public string MediaTagNameEnglish { get; set; }

            /// <summary>
            /// <para>The options.</para>
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public List<ListAllPublicMediaTagsResponseBodyMediaTagListOptions> Options { get; set; }
            public class ListAllPublicMediaTagsResponseBodyMediaTagListOptions : TeaModel {
                /// <summary>
                /// <para>The option name in Chinese.</para>
                /// </summary>
                [NameInMap("OptionChineseName")]
                [Validation(Required=false)]
                public string OptionChineseName { get; set; }

                /// <summary>
                /// <para>The option name in English.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Angry</para>
                /// </summary>
                [NameInMap("OptionEnglishName")]
                [Validation(Required=false)]
                public string OptionEnglishName { get; set; }

                /// <summary>
                /// <para>The option ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Angry</para>
                /// </summary>
                [NameInMap("OptionId")]
                [Validation(Required=false)]
                public string OptionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B45F83B7-7F87-4792-BFE9-63CD2137CAF0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
