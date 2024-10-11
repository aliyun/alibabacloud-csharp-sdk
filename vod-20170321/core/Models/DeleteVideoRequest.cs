// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteVideoRequest : TeaModel {
        /// <summary>
        /// <para>The list of video IDs. Separate multiple IDs with commas (,). A maximum of 20 IDs can be specified. You can obtain a video ID in one of the following ways:</para>
        /// <list type="bullet">
        /// <item><description>If the video is uploaded by using the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>, log on to the console and choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the ID of the video.</description></item>
        /// <item><description>If the video is uploaded by calling the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation, the video ID is the VideoId value in the response.</description></item>
        /// <item><description>You can also call the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation to obtain the video ID, which is the VideoId value in the response.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e44ebf1147hdsa2d2adbea8b****,e44ebf11oj984adbea8****,73ab850b4f6f4b6e91d24d81d54****</para>
        /// </summary>
        [NameInMap("VideoIds")]
        [Validation(Required=false)]
        public string VideoIds { get; set; }

    }

}
