// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddShowIntoShowListRequest : TeaModel {
        /// <summary>
        /// <para>The production studio ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If you created the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the CasterId value returned by the CreateCaster operation.</para>
        /// </description></item>
        /// <item><description><para>If you created the production studio in the ApsaraVideo Live console, navigate to <b>ApsaraVideo Live console</b> &gt; <b>Production Studios</b> &gt; <b>Cloud Production Studio</b> to view the production studio name.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The production studio name in the production studio list on the Cloud Production Studio page of the ApsaraVideo Live console is the production studio ID.</para>
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
        /// <para>The playback duration of a single show. Unit: seconds.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can set only one of <b>RepeatTimes</b> and <b>Duration</b>.</description></item>
        /// <item><description>This parameter is required when ResourceType is set to live.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>The custom type tag.</para>
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
        /// <para>The number of times a single show is repeated. Default value: 0.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can set only one of <b>RepeatTimes</b> and <b>Duration</b>.- RepeatTimes specifies the number of repetitions. For example, -1 means infinite repetition, 0 means the show is repeated 0 times (played once), 1 means the show is repeated 1 time (played twice), and so on.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RepeatTimes")]
        [Validation(Required=false)]
        public int? RepeatTimes { get; set; }

        /// <summary>
        /// <para>The VOD file ID.</para>
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
        /// <item><description>live: live streaming resource.</description></item>
        /// <item><description>vod: video-on-demand resource.</description></item>
        /// <item><description>pic: image resource.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When using video-on-demand (VOD) resources, use managed Bucket resources first. Resources in your own Bucket may expire. If you use resources in your own Bucket, check the resource validity period.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Live files support live streaming resources and third-party URLs.</description></item>
        /// <item><description>VOD files support video-on-demand resources, image resources, and third-party URLs.</description></item>
        /// <item><description>When using live streaming resources, you must also specify the Duration parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vod</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The URL of the playback file.</para>
        /// </summary>
        [NameInMap("ResourceUrl")]
        [Validation(Required=false)]
        public string ResourceUrl { get; set; }

        /// <summary>
        /// <para>The show name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveShow****</para>
        /// </summary>
        [NameInMap("ShowName")]
        [Validation(Required=false)]
        public string ShowName { get; set; }

        /// <summary>
        /// <para>The position in the playlist where the show is inserted. Positions start from 0. By default, the show is added to the end of the current playlist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Spot")]
        [Validation(Required=false)]
        public int? Spot { get; set; }

        /// <summary>
        /// <para>Specifies whether to add shows to the playlist in batch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Batch addition.</para>
        /// </description></item>
        /// <item><description><para>false: Single addition.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified or left empty, single addition is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isBatchMode")]
        [Validation(Required=false)]
        public bool? IsBatchMode { get; set; }

        /// <summary>
        /// <para>The list of show resources to add. Each resource has independent parameters such as showName and resourceUrl.</para>
        /// </summary>
        [NameInMap("showList")]
        [Validation(Required=false)]
        public List<AddShowIntoShowListRequestShowList> ShowList { get; set; }
        public class AddShowIntoShowListRequestShowList : TeaModel {
            /// <summary>
            /// <para>The playback duration of a single show. Unit: seconds.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>You can set only one of <b>repeatTimes</b> and <b>duration</b>.</description></item>
            /// <item><description>This parameter is required when resourceType is set to live.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The custom type tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("liveInputType")]
            [Validation(Required=false)]
            public int? LiveInputType { get; set; }

            /// <summary>
            /// <para>The number of times a single show is repeated. Default value: 0.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>You can set only one of <b>repeatTimes</b> and <b>duration</b>.</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>repeatTimes specifies the number of repetitions. For example, 0 means the show is repeated 0 times (played once), 1 means the show is repeated 1 time (played twice), and so on.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("repeatTimes")]
            [Validation(Required=false)]
            public int? RepeatTimes { get; set; }

            /// <summary>
            /// <para>The VOD file ID.</para>
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
            /// <item><description><para>live: live streaming resource.</para>
            /// </description></item>
            /// <item><description><para>vod: video-on-demand resource.</para>
            /// </description></item>
            /// <item><description><para>pic: image resource.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>When using video-on-demand (VOD) resources, use managed Bucket resources first. Resources in your own Bucket may expire. If you use resources in your own Bucket, check the resource validity period.</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>Live files support live streaming resources and third-party URLs.</description></item>
            /// <item><description>VOD files support video-on-demand resources, image resources, and third-party URLs.</description></item>
            /// <item><description>When using live streaming resources, you must also specify the duration parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vod</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The URL of the playback file.</para>
            /// </summary>
            [NameInMap("resourceUrl")]
            [Validation(Required=false)]
            public string ResourceUrl { get; set; }

            /// <summary>
            /// <para>The show name.</para>
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
