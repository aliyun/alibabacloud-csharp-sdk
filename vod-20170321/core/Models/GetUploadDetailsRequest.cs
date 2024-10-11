// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetUploadDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the media file, namely, the audio or video ID. You can specify a maximum of 20 IDs. Separate multiple IDs with commas (,). You can use one of the following methods to obtain the audio or video ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD</a> console. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Audio/Video</b>. On the Video and Audio page, you can view the audio or video ID. Use this method if the audio or video file is uploaded by using the ApsaraVideo VOD console.</description></item>
        /// <item><description>View the value of the VideoId parameter returned by the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation that you called to obtain an upload URL and credential.</description></item>
        /// <item><description>View the value of the VideoId parameter returned by the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation that you called to query media information after the audio or video file is uploaded.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61ccbdb06fa83012be4d8083f6****,7d2fbc380b0e08e55f****</para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        /// <summary>
        /// <para>The type of the media file. Set the value to <b>video</b>, which indicates audio and video files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

    }

}
