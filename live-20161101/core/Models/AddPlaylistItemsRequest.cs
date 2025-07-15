// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddPlaylistItemsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <list type="bullet">
        /// <item><description>If the production studio was created by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the value of the response parameter CasterId to obtain the ID.</description></item>
        /// <item><description>If the production studio was created by using the ApsaraVideo Live console, obtain the ID on the <b>Production Studio Management</b> page. To go to the page, log on to the <b>ApsaraVideo Live console</b> and click <b>Production Studios</b> in the left-side navigation pane.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can find the ID of the production studio in the Instance ID/Name column.</para>
        /// </remarks>
        /// <para>The production studio must use the following configurations:</para>
        /// <list type="bullet">
        /// <item><description><b>NormType</b>: 3****. You need to call the <b>CreateCaster</b> operation to create a production studio for lightweight carousel playback in advance.</description></item>
        /// <item><description><b>CasterTemplate</b>: lp_noTranscode.</description></item>
        /// <item><description><b>channelEnable</b>: 0.</description></item>
        /// <item><description><b>programEffect</b>: 1.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0e94d1f4-1a65-445c-9dcf-de8b3b8d****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The configurations of the episode list. If the episode list is added to the production studio for the first time, specify this parameter to pass in the initial configurations. For more information, see the <b>ProgramConfig</b> section of this topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;RepeatNumber&quot;:&quot;0&quot;,&quot;ProgramName&quot;:&quot;my program&quot;}]</para>
        /// </summary>
        [NameInMap("ProgramConfig")]
        [Validation(Required=false)]
        public string ProgramConfig { get; set; }

        /// <summary>
        /// <para>The ID of the episode list. If you do not specify this parameter, an episode list is created by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("ProgramId")]
        [Validation(Required=false)]
        public string ProgramId { get; set; }

        /// <summary>
        /// <para>The episodes that you want to add to the production studio. The value is a JSON string. For more information, see the <b>InputProgramItem</b> section of this topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ItemName&quot;:&quot;item1&quot;,&quot;ResourceType&quot;:&quot;vod&quot;,&quot;ResourceValue&quot;:&quot;5f8809f2-3352-4d1f-a8f7-86f9429f****&quot;}, {&quot;ItemName&quot;: &quot;item2&quot;,&quot;ResourceType&quot;: &quot;vod&quot;,&quot;ResourceValue&quot;: &quot;e7411c0b-dd98-4c61-a545-f8bfba6c****&quot;}]</para>
        /// </summary>
        [NameInMap("ProgramItems")]
        [Validation(Required=false)]
        public string ProgramItems { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
