// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RestoreMediaRequest : TeaModel {
        /// <summary>
        /// <para>The media IDs, which are audio or video IDs (VideoId). Separate multiple IDs with commas (,). A maximum of 20 IDs are supported. You can obtain the IDs by using the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For audio or video files uploaded in the console, log on to the ApsaraVideo VOD console and choose Media Files &gt; Audio/Video to view the audio or video ID.</description></item>
        /// <item><description>When you call the CreateUploadVideo operation to obtain the upload URL and credential, the video ID is the value of the VideoId parameter in the response.</description></item>
        /// <item><description>After the audio or video file is uploaded, you can call the SearchMedia operation to query the video ID, which is the value of the VideoId parameter in the response.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8bc8e94fe4e55abde85718****,eb186180e989dd56****</para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        /// <summary>
        /// <para>The restoration duration. Default value: 1 day. Maximum value for Archive media assets: 7 days. Maximum value for Cold Archive media assets: 365 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RestoreDays")]
        [Validation(Required=false)]
        public string RestoreDays { get; set; }

        /// <summary>
        /// <para>The restoration priority. This parameter is required only for Cold Archive media assets. If this parameter is not specified, the default value <b>Standard</b> is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Expedited</b>: High priority. The restoration is completed within 1 hour.</description></item>
        /// <item><description><b>Standard</b> (default): Standard priority. The restoration is completed within 2 to 5 hours.</description></item>
        /// <item><description><b>Bulk</b>: Batch priority. The restoration is completed within 5 to 12 hours.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("RestoreTier")]
        [Validation(Required=false)]
        public string RestoreTier { get; set; }

        /// <summary>
        /// <para>The scope of the change. If this parameter is not specified, the default value <b>All</b> is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b> (default): Applies tiered storage to all resources (source files and transcoded streams) of the media asset.</description></item>
        /// <item><description><b>SourceFile</b>: Applies tiered storage only to the video source file of the media asset ID. Resources other than the source file use Standard storage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
