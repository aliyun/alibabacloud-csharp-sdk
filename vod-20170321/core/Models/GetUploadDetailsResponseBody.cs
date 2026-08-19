// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetUploadDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of media files that cannot be accessed.</para>
        /// </summary>
        [NameInMap("ForbiddenMediaIds")]
        [Validation(Required=false)]
        public List<string> ForbiddenMediaIds { get; set; }

        /// <summary>
        /// <para>The IDs of media files that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistMediaIds")]
        [Validation(Required=false)]
        public List<string> NonExistMediaIds { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E290613-04F4-47F4-795D30732077****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The upload details.</para>
        /// </summary>
        [NameInMap("UploadDetails")]
        [Validation(Required=false)]
        public List<GetUploadDetailsResponseBodyUploadDetails> UploadDetails { get; set; }
        public class GetUploadDetailsResponseBodyUploadDetails : TeaModel {
            /// <summary>
            /// <para>The completion time. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-04-28T09:45:07Z</para>
            /// </summary>
            [NameInMap("CompletionTime")]
            [Validation(Required=false)]
            public string CompletionTime { get; set; }

            /// <summary>
            /// <para>The creation time. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-04-28T09:42:07Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The device model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Chrome</para>
            /// </summary>
            [NameInMap("DeviceModel")]
            [Validation(Required=false)]
            public string DeviceModel { get; set; }

            /// <summary>
            /// <para>The file size. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>46</para>
            /// </summary>
            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            /// <summary>
            /// <para>The ID of the uploaded audio or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>61ccbdb06fa83012be4d8083f6****</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The modification time. The time is in the <em>yyyy-MM-ddTHH:mm:ssZ</em> format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-04-28T09:43:12Z</para>
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// <para>The video status. For the valid values and descriptions of video statuses, see the value list in <a href="https://help.aliyun.com/document_detail/52839.html">Status: video status</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Uploading</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The title.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test file upload details</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The upload IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.1</para>
            /// </summary>
            [NameInMap("UploadIP")]
            [Validation(Required=false)]
            public string UploadIP { get; set; }

            /// <summary>
            /// <para>The upload ratio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.038</para>
            /// </summary>
            [NameInMap("UploadRatio")]
            [Validation(Required=false)]
            public float? UploadRatio { get; set; }

            /// <summary>
            /// <para>The upload size. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>346</para>
            /// </summary>
            [NameInMap("UploadSize")]
            [Validation(Required=false)]
            public long? UploadSize { get; set; }

            /// <summary>
            /// <para>The upload source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WebSDK</para>
            /// </summary>
            [NameInMap("UploadSource")]
            [Validation(Required=false)]
            public string UploadSource { get; set; }

            /// <summary>
            /// <para>The upload task status. For the valid values and descriptions of upload statuses, see the value list in <a href="https://help.aliyun.com/document_detail/52839.html">Status: URL upload task status</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Uploading</para>
            /// </summary>
            [NameInMap("UploadStatus")]
            [Validation(Required=false)]
            public string UploadStatus { get; set; }

        }

    }

}
