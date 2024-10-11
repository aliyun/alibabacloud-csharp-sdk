// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListAIImageInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The image files that are uploaded for AI processing.</para>
        /// </summary>
        [NameInMap("AIImageInfoList")]
        [Validation(Required=false)]
        public List<ListAIImageInfoResponseBodyAIImageInfoList> AIImageInfoList { get; set; }
        public class ListAIImageInfoResponseBodyAIImageInfoList : TeaModel {
            /// <summary>
            /// <para>The ID of the image information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b89a6aabf1b6197ebd6fe6cf29****</para>
            /// </summary>
            [NameInMap("AIImageInfoId")]
            [Validation(Required=false)]
            public string AIImageInfoId { get; set; }

            /// <summary>
            /// <para>The time when the file was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-15T03:30:03Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The URL of the image file.</para>
            /// </summary>
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            /// <summary>
            /// <para>The format of the image. Valid values: <b>gif</b> and <b>png</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gif</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <para>The ID of the image AI processing job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cf08a2c6e11ee1711b738b9067****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The score of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.035636554444242</para>
            /// </summary>
            [NameInMap("Score")]
            [Validation(Required=false)]
            public string Score { get; set; }

            /// <summary>
            /// <para>The data version ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b547f3f0e199c3b457369f3cf****</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The ID of the video.</para>
            /// 
            /// <b>Example:</b>
            /// <para>357a8748c5789d2726e6436aa****</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D73420CD-D221-9122-5B8FA995A511****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
