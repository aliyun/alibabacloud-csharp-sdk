// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class BatchGetMediaInfosRequest : TeaModel {
        /// <summary>
        /// <para>The media asset IDs, namely the audio or video IDs (VideoId). Separate multiple IDs with commas (,). A maximum of 20 IDs are supported. You can obtain the IDs by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For audio or video files uploaded through the console, log on to the ApsaraVideo VOD console and choose Media Library &gt; Audio/Video to view the audio or video IDs.</description></item>
        /// <item><description>When you call the operation to obtain the upload URL and credential for an audio or video file, the ID is the value of the VideoId response parameter.</description></item>
        /// <item><description>After an audio or video file is uploaded, you can call the operation to search for media asset information. The ID is the value of the VideoId response parameter.</description></item>
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
        /// <para>The custom ID list. It consists of one or more custom IDs. Separate multiple IDs with commas (,). A maximum of 20 IDs are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123-123,1234-1234</para>
        /// </summary>
        [NameInMap("ReferenceIds")]
        [Validation(Required=false)]
        public string ReferenceIds { get; set; }

    }

}
