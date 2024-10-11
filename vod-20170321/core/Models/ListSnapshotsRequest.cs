// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListSnapshotsRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the snapshot URL. Default value: <b>3600</b>. Minimum value: <b>3600</b>. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when you enable URL signing. For more information, see <a href="https://help.aliyun.com/document_detail/57007.html">Configure URL signing</a>.</description></item>
        /// <item><description>If you specify a value smaller than <b>3,600 seconds</b>, <b>3600</b> is used by default.</description></item>
        /// <item><description>If the snapshot URL is an Object Storage Service (OSS) URL, the maximum value for this parameter is <b>2592000</b> (30 days). This reduces risks on the origin.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public string AuthTimeout { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public string PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>20</b>. Maximum value: <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The type of snapshots to return. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CoverSnapshot</b>: thumbnail snapshot</description></item>
        /// <item><description><b>NormalSnapshot</b>: regular snapshot</description></item>
        /// <item><description><b>SpriteSnapshot</b>: sprite snapshot</description></item>
        /// <item><description><b>SpriteOriginSnapshot</b>: sprite source snapshot</description></item>
        /// <item><description><b>WebVttSnapshot</b>: WebVTT snapshot</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CoverSnapshot</para>
        /// </summary>
        [NameInMap("SnapshotType")]
        [Validation(Required=false)]
        public string SnapshotType { get; set; }

        /// <summary>
        /// <para>The ID of the video. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the video ID.</description></item>
        /// <item><description>Obtain the video ID from the response to the <a href="~~CreateUploadVideo~~">CreateUploadVideo</a> operation that you call to obtain the upload URL and credential.</description></item>
        /// <item><description>Obtain the video ID from the response to the <a href="~~SearchMedia~~">SearchMedia</a> operation that you call to query videos.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d3e680e618708fbf2cae7cc931****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
