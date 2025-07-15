// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetShowListBackgroundRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description>If the production studio was created by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the value of the response parameter CasterId to obtain the ID.</description></item>
        /// <item><description>If the production studio was created by using the ApsaraVideo Live console, obtain the ID on the <b>Production Studio Management</b> page. To go to the page, log on to the <b>ApsaraVideo Live console</b> and click <b>Production Studios</b> in the left-side navigation pane.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can find the ID of the production studio in the Instance ID/Name column.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The ID of the material in ApsaraVideo VOD.</para>
        /// <remarks>
        /// <para> Specify either this parameter or the ResourceUrl parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
        /// </summary>
        [NameInMap("MaterialId")]
        [Validation(Required=false)]
        public string MaterialId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>LIVE: live stream. You can add a live stream from ApsaraVideo Live or by using a third-party URL.</description></item>
        /// <item><description>VOD: on-demand video. You can add an on-demand video from ApsaraVideo VOD or by using a third-party URL.</description></item>
        /// <item><description>PIC: image. You can add an image from ApsaraVideo VOD or by using a third-party URL.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Set this parameter to one of the preceding values, or leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>VOD</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The URL of the third-party material.</para>
        /// </summary>
        [NameInMap("ResourceUrl")]
        [Validation(Required=false)]
        public string ResourceUrl { get; set; }

    }

}
