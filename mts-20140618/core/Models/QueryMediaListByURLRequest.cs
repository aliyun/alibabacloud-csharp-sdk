// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaListByURLRequest : TeaModel {
        /// <summary>
        /// <para>The OSS URLs of the media files. To obtain the OSS URL of a media file, you can perform the following operations in the ApsaraVideo Media Processing (MPS) console: In the left-side navigation pane, choose <b>Media Management</b> &gt; <b>Media List</b>. Find the media file whose OSS URL you want to view and click <b>Manage</b> in the <b>Actions</b> column. The OSS URL of the media file is displayed on the <b>Obtain Encoding URL</b> tab. Separate multiple URLs with commas (,). You can query up to 10 media files at a time.</para>
        /// <list type="bullet">
        /// <item><description>The URL complies with RFC 3986 and is encoded in UTF-8, with reserved characters being percent-encoded. The value can be up to 3,200 bytes in size. For more information, see <a href="https://help.aliyun.com/document_detail/423796.html">URL encoding</a>.</description></item>
        /// <item><description>Only OSS HTTP URLs are supported. Alibaba Cloud CDN URLs and HTTPS URLs are not supported.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example-bucket-****.oss-cn-shanghai.aliyuncs.com/example.mp4">http://example-bucket-****.oss-cn-shanghai.aliyuncs.com/example.mp4</a></para>
        /// </summary>
        [NameInMap("FileURLs")]
        [Validation(Required=false)]
        public string FileURLs { get; set; }

        /// <summary>
        /// <para>Specifies whether to include media information in the returned result.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values: true and false.</para>
        /// </description></item>
        /// <item><description><para>Default value: <b>false</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>To obtain detailed information about the media files, set this parameter to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeMediaInfo")]
        [Validation(Required=false)]
        public bool? IncludeMediaInfo { get; set; }

        /// <summary>
        /// <para>Specifies whether to include playback information in the returned result.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: true and false.</description></item>
        /// <item><description>Default value: <b>false</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludePlayList")]
        [Validation(Required=false)]
        public bool? IncludePlayList { get; set; }

        /// <summary>
        /// <para>Specifies whether to include snapshot information in the returned result.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: true and false.</description></item>
        /// <item><description>Default value: <b>false</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeSnapshotList")]
        [Validation(Required=false)]
        public bool? IncludeSnapshotList { get; set; }

        /// <summary>
        /// <para>Specifies whether to include summaries in the returned result.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: true and false.</description></item>
        /// <item><description>Default value: <b>false</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeSummaryList")]
        [Validation(Required=false)]
        public bool? IncludeSummaryList { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
