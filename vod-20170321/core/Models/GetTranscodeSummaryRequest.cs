// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetTranscodeSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the audio or video file. You can specify up to 10 IDs. Separate the IDs with commas (,). You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>After you upload a video in the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>, you can log on to the ApsaraVideo VOD console and choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the ID of the video.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation that you call to obtain the upload URL and credential.</description></item>
        /// <item><description>Obtain the value of VideoId by calling the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation. This method is applicable to files that have been uploaded.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;d4860fcc6ae9fed52e8938244****,e1db68cc586644b83e562bcd94****,hhhhhhh&quot;</para>
        /// </summary>
        [NameInMap("VideoIds")]
        [Validation(Required=false)]
        public string VideoIds { get; set; }

    }

}
