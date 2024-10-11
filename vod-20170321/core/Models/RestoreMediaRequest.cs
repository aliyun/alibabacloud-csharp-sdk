// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RestoreMediaRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the media asset (VideoId). Separate multiple IDs with commas (,). You can specify a maximum of 20 IDs. You can use one of the following methods to obtain the ID of the media asset:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the ApsaraVideo VOD console. In the left-side navigation pane, choose Media Files &gt; Audio/Video. On the Video and Audio page, view the ID of the media asset. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the CreateUploadVideo operation that you call to upload media assets.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the SearchMedia operation that you call to query the media ID after the media asset is uploaded.</description></item>
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
        /// <para>The number of days during which media assets remain in the restored state. Default value: 1. The maximum validity period of a restored Archive media asset is 7 days and the maximum validity period of a restored Cold Archive media asset is 365 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RestoreDays")]
        [Validation(Required=false)]
        public string RestoreDays { get; set; }

        /// <summary>
        /// <para>The restoration priority. This parameter is required only when you restore a Cold Archive media file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Expedited</b>: The file is restored within 1 hour.</description></item>
        /// <item><description><b>Standard</b>: The file is restored within 2 to 5 hours.</description></item>
        /// <item><description><b>Bulk</b>: The file is restored within 5 to 12 hours.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("RestoreTier")]
        [Validation(Required=false)]
        public string RestoreTier { get; set; }

        /// <summary>
        /// <para>The modification range. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>All</b>: restores all resources, including the source files and transcoded streams.</description></item>
        /// <item><description><b>SourceFile</b>: restores only the source files.</description></item>
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
