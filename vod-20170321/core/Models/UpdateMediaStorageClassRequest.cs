// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateMediaStorageClassRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow storage class modification for media assets that have not met the minimum storage duration requirement. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Allowed.</description></item>
        /// <item><description><b>false (default)</b>: Not allowed.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the storage duration of a media asset is insufficient and you force a storage class modification, additional retrieval fees are incurred.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowUpdateWithoutTimeLimit")]
        [Validation(Required=false)]
        public bool? AllowUpdateWithoutTimeLimit { get; set; }

        /// <summary>
        /// <para>The media IDs, which are audio or video IDs (VideoId). Separate multiple IDs with commas (,). A maximum of 20 IDs are supported. You can obtain the IDs by using the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For audio or video files uploaded through the console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the audio or video ID.</description></item>
        /// <item><description>When you call the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation to obtain the upload URL and credential, the video ID is the value of the VideoId response parameter.</description></item>
        /// <item><description>After the audio or video file is uploaded, you can call the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation to query the video ID, which is the value of the VideoId response parameter.</description></item>
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
        /// <para>The restore priority (required only for ColdArchive media assets). If this parameter is not specified, the default value <b>Standard</b> is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Expedited</b>: Expedited</description></item>
        /// <item><description><b>Standard</b> (default): Standard</description></item>
        /// <item><description><b>Bulk</b>: Bulk</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("RestoreTier")]
        [Validation(Required=false)]
        public string RestoreTier { get; set; }

        /// <summary>
        /// <para>The scope of the modification. If this parameter is not specified, the default value <b>All</b> is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b> (default): Applies tiered storage to all resources (source files and transcoded streams) of the media asset.</description></item>
        /// <item><description><b>SourceFile</b>: Applies tiered storage only to the source file of the media asset. Resources other than the source file use Standard storage.</description></item>
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
        /// <item><description><b>Standard</b>: Standard</description></item>
        /// <item><description><b>IA</b>: Infrequent Access</description></item>
        /// <item><description><b>Archive</b>: Archive</description></item>
        /// <item><description><b>ColdArchive</b>: Cold Archive</description></item>
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
