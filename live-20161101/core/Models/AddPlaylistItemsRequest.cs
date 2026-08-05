// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddPlaylistItemsRequest : TeaModel {
        /// <summary>
        /// <para>The production studio ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If you created the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster operation</a>, check the CasterId parameter value returned by the CreateCaster operation.</para>
        /// </description></item>
        /// <item><description><para>If you created the production studio in the ApsaraVideo Live console, navigate to <b>ApsaraVideo Live console</b> &gt; <b>Production Studios</b> &gt; <b>Cloud Production Studio</b> to view the production studio name.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The production studio name in the production studio list on the Cloud Production Studio page of the ApsaraVideo Live console is the production studio ID.</para>
        /// </remarks>
        /// <para>The production studio must meet the following configurations:</para>
        /// <list type="bullet">
        /// <item><description><b>NormType</b>: <b>3</b>. Create a lightweight carousel production studio in advance. You can call the <b>CreateCaster</b> operation to create a production studio.</description></item>
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
        /// <para>The playlist item configuration. If this is the first time you add a playlist item, specify this parameter for initialization. For more information, see <b>ProgramConfig</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;RepeatNumber&quot;:&quot;0&quot;,&quot;ProgramName&quot;:&quot;my program&quot;}]</para>
        /// </summary>
        [NameInMap("ProgramConfig")]
        [Validation(Required=false)]
        public string ProgramConfig { get; set; }

        /// <summary>
        /// <para>The playlist ID. If the production studio already has a playlist, you must specify the corresponding ProgramId. If no playlist has been created, you can leave this parameter empty, and the system performs automatic creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>445409ec-7eaa-461d-8f29-4bec2eb9****</para>
        /// </summary>
        [NameInMap("ProgramId")]
        [Validation(Required=false)]
        public string ProgramId { get; set; }

        /// <summary>
        /// <para>The list of playlist item inputs. The value is a JSON string. For more information, see <b>InputProgramItem</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;ItemName&quot;:&quot;item1&quot;,&quot;ResourceType&quot;:&quot;vod&quot;,&quot;ResourceValue&quot;:&quot;5f8809f2-3352-4d1f-a8f7-86f9429f****&quot;}, {&quot;ItemName&quot;: &quot;item2&quot;,&quot;ResourceType&quot;: &quot;vod&quot;,&quot;ResourceValue&quot;: &quot;e7411c0b-dd98-4c61-a545-f8bfba6c****&quot;}]</para>
        /// </summary>
        [NameInMap("ProgramItems")]
        [Validation(Required=false)]
        public string ProgramItems { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
