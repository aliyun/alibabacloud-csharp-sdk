// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyShowListRequest : TeaModel {
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
        /// <para>The episode of the highest priority.</para>
        /// <remarks>
        /// <para> You can configure this parameter only before the playback of the episode list starts.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
        /// </summary>
        [NameInMap("HighPriorityShowId")]
        [Validation(Required=false)]
        public string HighPriorityShowId { get; set; }

        /// <summary>
        /// <para>The time at which the episode of the highest priority is played. Format: yyyy-MM-dd\&quot;T\&quot;HH:mm:ss.</para>
        /// <remarks>
        /// <para> You can configure this parameter only before the episode list starts playing.\
        /// After you configure this parameter, when the specified point in time is reached, any episode that is playing stops and the episode of the highest priority in the episode list starts to play.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-11-23T12:30:00</para>
        /// </summary>
        [NameInMap("HighPriorityShowStartTime")]
        [Validation(Required=false)]
        public string HighPriorityShowStartTime { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of additional times the episode list is played.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The RepeatTimes parameter specifies the number of repetitions. For example, if you set the value to <b>0</b>, the episode list is played <b>once</b>. If you set the value to <b>1</b>, the episode list is played <b>twice</b>.********</para>
        /// </description></item>
        /// <item><description><para>If you set the value to -1, the episode list is repeated indefinitely.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RepeatTimes")]
        [Validation(Required=false)]
        public int? RepeatTimes { get; set; }

        /// <summary>
        /// <para>The ID of the episode for which you want to change the position in the playlist.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2848051.html">AddShowIntoShowList</a> or <a href="https://help.aliyun.com/document_detail/2848054.html">DescribeShowList</a> operation and check the value of the response parameter ShowId to obtain the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
        /// </summary>
        [NameInMap("ShowId")]
        [Validation(Required=false)]
        public string ShowId { get; set; }

        /// <summary>
        /// <para>The position of the episode in the episode list. If you want to change the position of an episode in a playlist, place the ID of the episode in <b>Spot</b>.</para>
        /// <remarks>
        /// <para> The value must be greater than or equal to 0 and less than or equal to the total number of episodes in the playlist.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Spot")]
        [Validation(Required=false)]
        public int? Spot { get; set; }

    }

}
