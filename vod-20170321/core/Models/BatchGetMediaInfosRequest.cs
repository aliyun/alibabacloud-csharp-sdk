// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class BatchGetMediaInfosRequest : TeaModel {
        /// <summary>
        /// <para>The media asset IDs, which are audio/video IDs (VideoId). Separate multiple IDs with commas (,). You can specify up to 20 IDs. You can obtain the IDs by using the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For audio/video files uploaded through the console, log on to the ApsaraVideo VOD console and choose Media Files &gt; Audio/Video to view the audio/video IDs.</description></item>
        /// <item><description>When you call the operation to obtain the upload URL and credential for audio/video files, the VideoId value is returned as a response parameter.</description></item>
        /// <item><description>After an audio/video file is uploaded, you can call the SearchMedia operation to query the VideoId value in the response.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61ccbdb06fa83012be4d8083f6****,7d2fbc380b0e08e55f****</para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        /// <summary>
        /// <para>The list of custom IDs. Separate multiple custom IDs with commas (,). You can specify up to 20 IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123-123,1234-1234</para>
        /// </summary>
        [NameInMap("ReferenceIds")]
        [Validation(Required=false)]
        public string ReferenceIds { get; set; }

    }

}
