// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeCloudNotePhrasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The hotword lists.</para>
        /// </summary>
        [NameInMap("Phrases")]
        [Validation(Required=false)]
        public List<DescribeCloudNotePhrasesResponseBodyPhrases> Phrases { get; set; }
        public class DescribeCloudNotePhrasesResponseBodyPhrases : TeaModel {
            /// <summary>
            /// <para>The creation time. Format: yyyy-MM-ddTHH:mm:ssZ (UTC time).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-04T06:22:15Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Fruit description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The hotword list ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1qweadca332121212</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The hotword list name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Fruit</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The hotword weights.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("WordWeights")]
            [Validation(Required=false)]
            public List<DescribeCloudNotePhrasesResponseBodyPhrasesWordWeights> WordWeights { get; set; }
            public class DescribeCloudNotePhrasesResponseBodyPhrasesWordWeights : TeaModel {
                /// <summary>
                /// <para>The weight value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

                /// <summary>
                /// <para>The hotword.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Apple</para>
                /// </summary>
                [NameInMap("Word")]
                [Validation(Required=false)]
                public string Word { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3A26E1E3-3CBB-599E-AD68-CB78F5A42FA1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}
