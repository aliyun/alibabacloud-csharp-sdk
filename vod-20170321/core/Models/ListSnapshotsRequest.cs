// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListSnapshotsRequest : TeaModel {
        /// <summary>
        /// <para>The expiration time of the snapshot access URL. Default value: <b>3600</b>. Minimum value: <b>3600</b>. Unit: seconds.</para>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only if <a href="https://help.aliyun.com/document_detail/57007.html">URL authentication</a> is enabled.</description></item>
        /// <item><description>If the specified value is less than <b>3600 seconds</b>, the default value of <b>3600 seconds</b> is used.</description></item>
        /// <item><description>If the returned URL is an OSS URL, the maximum value is <b>2592000</b> (30 days) to reduce security risks to the origin server.</description></item>
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
        /// <item><description><b>CoverSnapshot</b> (default): thumbnail snapshots.</description></item>
        /// <item><description><b>NormalSnapshot</b>: normal snapshots.</description></item>
        /// <item><description><b>SpriteSnapshot</b>: sprites.</description></item>
        /// <item><description><b>SpriteOriginSnapshot</b>: original images of sprites.</description></item>
        /// <item><description><b>WebVttSnapshot</b>: WebVTT snapshots.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CoverSnapshot</para>
        /// </summary>
        [NameInMap("SnapshotType")]
        [Validation(Required=false)]
        public string SnapshotType { get; set; }

        /// <summary>
        /// <para>The video ID. You can obtain the video ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the video ID.</description></item>
        /// <item><description>Obtain the video ID from the response of the <a href="~~CreateUploadVideo~~">CreateUploadVideo</a> operation that you call to obtain the upload URL and credential.</description></item>
        /// <item><description>Obtain the video ID from the response of the <a href="~~SearchMedia~~">SearchMedia</a> operation that you call to query videos.</description></item>
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
