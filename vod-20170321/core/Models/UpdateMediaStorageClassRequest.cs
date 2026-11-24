// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateMediaStorageClassRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow the storage class modification for media assets that do not meet the minimum storage duration requirement. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Allowed.</description></item>
        /// <item><description><b>false</b> (default): Not allowed.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the storage duration of the media asset is insufficient, forcing a storage class modification incurs additional data retrieval fees.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowUpdateWithoutTimeLimit")]
        [Validation(Required=false)]
        public bool? AllowUpdateWithoutTimeLimit { get; set; }

        /// <summary>
        /// <para>The media asset IDs, which are the audio or video IDs (VideoId). Separate multiple IDs with commas (,). You can specify up to 20 IDs. You can obtain the IDs by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For audio or video files uploaded through the console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Assets</b> &gt; <b>Audio/Video</b> to view the audio or video IDs.</description></item>
        /// <item><description>When you call the <a href="https://help.aliyun.com/document_detail/55407.html">Obtain upload URLs and credentials for audio and video files</a> operation, the value of the VideoId response parameter is the media asset ID.</description></item>
        /// <item><description>After an audio or video file is uploaded, you can call the <a href="https://help.aliyun.com/document_detail/86044.html">Search for media asset information</a> operation to query the media asset ID. The value of the VideoId response parameter is the media asset ID.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d56c2ac0cee271ed80004710b5ba****</para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        /// <summary>
        /// <para>The restoration priority. This parameter is required only for Cold Archive media assets. If you do not specify this parameter, the default value <b>Standard</b> is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Expedited</b>: Expedited.</description></item>
        /// <item><description><b>Standard</b> (default): Standard.</description></item>
        /// <item><description><b>Bulk</b>: Bulk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("RestoreTier")]
        [Validation(Required=false)]
        public string RestoreTier { get; set; }

        /// <summary>
        /// <para>The scope of the modification. If you do not specify this parameter, the default value <b>All</b> is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b> (default): applies tiered storage to all resources of the media asset, including the source file and transcoded streams.</description></item>
        /// <item><description><b>SourceFile</b>: applies tiered storage only to the video source file of the media asset ID. Resources other than the source file are stored in Standard storage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The storage class. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Standard</b>: Standard.</description></item>
        /// <item><description><b>IA</b>: Infrequent Access (IA).</description></item>
        /// <item><description><b>Archive</b>: Archive.</description></item>
        /// <item><description><b>ColdArchive</b>: Cold Archive.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Archive</para>
        /// </summary>
        [NameInMap("StorageClass")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

    }

}
