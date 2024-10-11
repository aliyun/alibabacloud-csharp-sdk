// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitPreprocessJobsRequest : TeaModel {
        /// <summary>
        /// <para>The preprocessing type. Set the value to <b>LivePreprocess</b>. LivePreprocess specifies that the video is preprocessed in the production studio.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LivePreprocess</para>
        /// </summary>
        [NameInMap("PreprocessType")]
        [Validation(Required=false)]
        public string PreprocessType { get; set; }

        /// <summary>
        /// <para>The ID of the video. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>After you upload a video in the ApsaraVideo VOD console, you can log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the ID of the video.</description></item>
        /// <item><description>Obtain the VideoId from the response to the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation that you call to upload videos.</description></item>
        /// <item><description>Obtain the VideoId from the response to the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation that you call to query videos.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d3e680e618708efbf2cae7cc9312****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
