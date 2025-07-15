// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddShowIntoShowListRequest : TeaModel {
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
        /// <para>The duration of the episode. Unit: seconds.</para>
        /// <remarks>
        /// <para>You can specify only one of the <b>RepeatTimes</b> and <b>Duration</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>The custom type label.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LiveInputType")]
        [Validation(Required=false)]
        public int? LiveInputType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of times the episode repeats after the first playback is complete. The default value is 0.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can specify only one of the <b>RepeatTimes</b> and <b>Duration</b> parameters. - The RepeatTimes parameter specifies the number of repetitions. For example, if you set the value to -1, the episode is to be played for infinite times. If you set the value to 0, the episode is to be played once. If you set the value to 1, the episode is to be played twice.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RepeatTimes")]
        [Validation(Required=false)]
        public int? RepeatTimes { get; set; }

        /// <summary>
        /// <para>The ID of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>live: live stream</description></item>
        /// <item><description>vod: on-demand video</description></item>
        /// <item><description>pic: image</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>When you select media resources from ApsaraVideo VOD, we recommend that you select resources that are stored in hosted OSS buckets. Resources stored in non-hosted OSS buckets have a validity period. Pay attention to the validity if you select resources that are stored in non-hosted OSS buckets. - You can add a live stream from ApsaraVideo Live or by using a third-party URL. - You can add an on-demand video from ApsaraVideo VOD or by using a third-party URL, or add an on-demand image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vod</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The URL of the resource.</para>
        /// </summary>
        [NameInMap("ResourceUrl")]
        [Validation(Required=false)]
        public string ResourceUrl { get; set; }

        /// <summary>
        /// <para>The name of the episode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveShow****</para>
        /// </summary>
        [NameInMap("ShowName")]
        [Validation(Required=false)]
        public string ShowName { get; set; }

        /// <summary>
        /// <para>The position of the episode in the episode list. Position indexes start from 0. By default, the episode is added to the end of the episode list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Spot")]
        [Validation(Required=false)]
        public int? Spot { get; set; }

        /// <summary>
        /// <para>Specifies whether to add multiple episodes to the episode list at a time. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: adds multiple episodes to the episode list at a time.</description></item>
        /// <item><description>false: adds a single episode to the episode list.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter or this parameter is left empty, a single episode is to be added to the episode list.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isBatchMode")]
        [Validation(Required=false)]
        public bool? IsBatchMode { get; set; }

        /// <summary>
        /// <para>The episodes that you want to add to the episode list. Each episode has a unique name and resource URL.</para>
        /// </summary>
        [NameInMap("showList")]
        [Validation(Required=false)]
        public List<AddShowIntoShowListRequestShowList> ShowList { get; set; }
        public class AddShowIntoShowListRequestShowList : TeaModel {
            /// <summary>
            /// <para>The duration of the episode. Unit: seconds.</para>
            /// <remarks>
            /// <para> You can specify only one of the <b>RepeatTimes</b> and <b>Duration</b> parameters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The custom type label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("liveInputType")]
            [Validation(Required=false)]
            public int? LiveInputType { get; set; }

            /// <summary>
            /// <para>The number of times the episode repeats after the first playback is complete. Default value: 0.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>You can specify only one of the <b>RepeatTimes</b> and <b>Duration</b> parameters.</para>
            /// </description></item>
            /// <item><description><para>The RepeatTimes parameter specifies the number of repetitions. For example, if you set the value to 0, the episode is to be played once. If you set the value to 1, the episode is to be played twice.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("repeatTimes")]
            [Validation(Required=false)]
            public int? RepeatTimes { get; set; }

            /// <summary>
            /// <para>The ID of the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
            /// </summary>
            [NameInMap("resourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>live: live stream</description></item>
            /// <item><description>vod: on-demand video</description></item>
            /// <item><description>pic: image</description></item>
            /// </list>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>When you select media resources from ApsaraVideo VOD, we recommend that you select resources that are stored in hosted OSS buckets. Resources stored in non-hosted OSS buckets have a validity period. Pay attention to the validity if you select resources that are stored in non-hosted OSS buckets.</para>
            /// </description></item>
            /// <item><description><para>You can add a live stream from ApsaraVideo Live or by using a third-party URL.</para>
            /// </description></item>
            /// <item><description><para>You can add an on-demand video from ApsaraVideo VOD or by using a third-party URL, or add an on-demand image.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vod</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The URL of the resource.</para>
            /// </summary>
            [NameInMap("resourceUrl")]
            [Validation(Required=false)]
            public string ResourceUrl { get; set; }

            /// <summary>
            /// <para>The name of the episode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveShow****</para>
            /// </summary>
            [NameInMap("showName")]
            [Validation(Required=false)]
            public string ShowName { get; set; }

        }

    }

}
