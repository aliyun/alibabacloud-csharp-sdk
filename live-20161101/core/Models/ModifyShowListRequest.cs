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
        /// <item><description><para>If you created the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, use the CasterId value returned in the response.</para>
        /// </description></item>
        /// <item><description><para>If you created the production studio in the LIVE console, find the production studio name on the Cloud Production Studio page. To go to the page, choose <b>LIVE Console</b> &gt; <b>Production Studio</b> &gt; <b>Cloud Production Studio</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The name of the production studio on the Cloud Production Studio page is the production studio ID.</para>
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
        /// <para>The highest-priority show.</para>
        /// <remarks>
        /// <para>This parameter can be configured only before the playlist starts.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
        /// </summary>
        [NameInMap("HighPriorityShowId")]
        [Validation(Required=false)]
        public string HighPriorityShowId { get; set; }

        /// <summary>
        /// <para>The time to play the highest-priority show. The format is yyyy-MM-dd\&quot;T\&quot;HH:mm:ss.</para>
        /// <remarks>
        /// <para>This parameter can be configured only before the playlist starts.<br>
        /// After this parameter is configured, the system switches from the currently playing show to the highest-priority show at the specified time.</para>
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

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of times the playlist loops.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>RepeatTimes specifies the number of repetitions. For example, a value of <b>0</b> means the playlist is played once without repetition. A value of <b>1</b> means the playlist is played twice (one initial playback and one repetition).</para>
        /// </description></item>
        /// <item><description><para>A value of -1 indicates that the playlist loops indefinitely.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RepeatTimes")]
        [Validation(Required=false)]
        public int? RepeatTimes { get; set; }

        /// <summary>
        /// <para>The ID of the show whose position in the playlist you want to modify.</para>
        /// <remarks>
        /// <para>Obtain the ShowId value from the response of the <a href="https://help.aliyun.com/document_detail/2848051.html">AddShowIntoShowList</a> or <a href="https://help.aliyun.com/document_detail/2848054.html">DescribeShowList</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
        /// </summary>
        [NameInMap("ShowId")]
        [Validation(Required=false)]
        public string ShowId { get; set; }

        /// <summary>
        /// <para>The new position of the show in the playlist. The show specified by ShowId is moved to the position specified by <b>Spot</b>.</para>
        /// <remarks>
        /// <para>The value must be greater than or equal to 0 and less than or equal to the total number of shows in the playlist.</para>
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
