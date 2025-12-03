// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class BatchGetMediaInfosRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the media asset. The ID can be the video ID or audio ID. Separate IDs with commas (,). You can specify a maximum of 20 IDs. You can use one of the following methods to obtain the ID of the media asset:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the ApsaraVideo VOD console. In the left-side navigation pane, choose Media Files &gt; Audio/Video. On the Video and Audio page, view the ID of the media asset. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the CreateUploadVideo operation that you call to upload media assets.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the SearchMedia operation that you call to query the media ID after the media asset is uploaded.</description></item>
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
        /// <b>Example:</b>
        /// <para>123-123,1234-1234</para>
        /// </summary>
        [NameInMap("ReferenceIds")]
        [Validation(Required=false)]
        public string ReferenceIds { get; set; }

    }

}
