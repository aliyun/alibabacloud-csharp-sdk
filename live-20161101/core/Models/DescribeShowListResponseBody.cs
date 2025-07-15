// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeShowListResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>****Details of the episode list.</para>
        /// <para>Show indicates the information about a specific episode. For more information, see the <b>Show</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ShowList[Show1, Show2, Show3...]</para>
        /// </summary>
        [NameInMap("ShowList")]
        [Validation(Required=false)]
        public string ShowList { get; set; }

        /// <summary>
        /// <para>The information about the episode list.</para>
        /// </summary>
        [NameInMap("ShowListInfo")]
        [Validation(Required=false)]
        public DescribeShowListResponseBodyShowListInfo ShowListInfo { get; set; }
        public class DescribeShowListResponseBodyShowListInfo : TeaModel {
            /// <summary>
            /// <para>The background of the episode list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;MaterialId\&quot;:\&quot;a2b8e671-2fe5-4642-a2ec-bf93880e****\&quot;,\&quot;resourceType\&quot;:\&quot;VOD\&quot;}</para>
            /// </summary>
            [NameInMap("Background")]
            [Validation(Required=false)]
            public string Background { get; set; }

            /// <summary>
            /// <para>The ID of the episode that is playing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
            /// </summary>
            [NameInMap("CurrentShowId")]
            [Validation(Required=false)]
            public string CurrentShowId { get; set; }

            /// <summary>
            /// <para>The episode of the highest priority.</para>
            /// <remarks>
            /// <para>You can configure this parameter only before the episode list starts playing.</para>
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
            /// <para>You can configure this parameter only before the episode list starts playing. After you configure this parameter, when the specified point in time is reached, any episode that is playing stops and the episode of the highest priority in the episode list starts to play.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-23T12:30:00</para>
            /// </summary>
            [NameInMap("HighPriorityShowStartTime")]
            [Validation(Required=false)]
            public string HighPriorityShowStartTime { get; set; }

            /// <summary>
            /// <para>The episodes in the episode list.</para>
            /// </summary>
            [NameInMap("ShowList")]
            [Validation(Required=false)]
            public DescribeShowListResponseBodyShowListInfoShowList ShowList { get; set; }
            public class DescribeShowListResponseBodyShowListInfoShowList : TeaModel {
                [NameInMap("Show")]
                [Validation(Required=false)]
                public List<DescribeShowListResponseBodyShowListInfoShowListShow> Show { get; set; }
                public class DescribeShowListResponseBodyShowListInfoShowListShow : TeaModel {
                    /// <summary>
                    /// <para>The duration of the episode. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                    /// <summary>
                    /// <para>The number of times the episode repeats after the first playback is complete.</para>
                    /// <para>For example, if you set the value to 0, the episode is to be played once. If you set the value to 1, the episode is to be played twice.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("RepeatTimes")]
                    [Validation(Required=false)]
                    public int? RepeatTimes { get; set; }

                    /// <summary>
                    /// <para>The resource information.</para>
                    /// </summary>
                    [NameInMap("ResourceInfo")]
                    [Validation(Required=false)]
                    public DescribeShowListResponseBodyShowListInfoShowListShowResourceInfo ResourceInfo { get; set; }
                    public class DescribeShowListResponseBodyShowListInfoShowListShowResourceInfo : TeaModel {
                        /// <summary>
                        /// <para>The custom type label.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("LiveInputType")]
                        [Validation(Required=false)]
                        public int? LiveInputType { get; set; }

                        /// <summary>
                        /// <para>The ID of the video-on-demand (VOD) file.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
                        /// </summary>
                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }

                        /// <summary>
                        /// <para>The type of the resource.</para>
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

                    }

                    /// <summary>
                    /// <para>The ID of the episode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
                    /// </summary>
                    [NameInMap("ShowId")]
                    [Validation(Required=false)]
                    public string ShowId { get; set; }

                    /// <summary>
                    /// <para>The name of the episode.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>liveShow****</para>
                    /// </summary>
                    [NameInMap("ShowName")]
                    [Validation(Required=false)]
                    public string ShowName { get; set; }

                }

            }

            /// <summary>
            /// <para>The number of additional times the episode list is played by default. The value is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ShowListRepeatTimes")]
            [Validation(Required=false)]
            public int? ShowListRepeatTimes { get; set; }

            /// <summary>
            /// <para>The number of additional times the episode list is played.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalShowListRepeatTimes")]
            [Validation(Required=false)]
            public int? TotalShowListRepeatTimes { get; set; }

        }

    }

}
