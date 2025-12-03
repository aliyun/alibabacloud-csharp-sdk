// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoPlayAuthRequest : TeaModel {
        /// <summary>
        /// <para>The API version. Set the value to <b>1.0.0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("ApiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// <para>The validity period of the playback credential. Unit: <b>seconds</b>. You cannot obtain the playback URL of a video by using a credential that has expired. A new credential is required.</para>
        /// <list type="bullet">
        /// <item><description>Default value: <b>100</b>.</description></item>
        /// <item><description>Valid values: <c>[100,3000]</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AuthInfoTimeout")]
        [Validation(Required=false)]
        public long? AuthInfoTimeout { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123-123</para>
        /// </summary>
        [NameInMap("ReferenceId")]
        [Validation(Required=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// <para>The ID of the media file. You can specify only one ID. You can use one of the following methods to obtain the ID of the file:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD</a> console. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Audio/Video</b>. On the Video and Audio page, view the ID of the media file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.</description></item>
        /// <item><description>Obtain the value of the VideoId parameter from the response to the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation.</description></item>
        /// <item><description>Obtain the value of the VideoId parameter from the response to the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation. This method is applicable to files that have been uploaded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dfde02284a5c46622a097adaf44a****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
