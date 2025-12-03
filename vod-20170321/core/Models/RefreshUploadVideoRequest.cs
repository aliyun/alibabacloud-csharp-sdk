// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RefreshUploadVideoRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123-123</para>
        /// </summary>
        [NameInMap("ReferenceId")]
        [Validation(Required=false)]
        public string ReferenceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the audio or video file. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Files</b> &gt; <b>Audio/Video</b> in the left-side navigation pane to view the ID.</description></item>
        /// <item><description>View the value of the VideoId parameter returned by the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation that you called to upload the audio or video file.</description></item>
        /// <item><description>After an audio or video file is uploaded, obtain the value of VideoId from the response to the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation that you call to query the audio or video ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>c6a23a870c8c4ffcd40cbd381333****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
