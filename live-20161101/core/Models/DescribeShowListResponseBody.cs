// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeShowListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the playlist. <c>Show</c> contains the details of a show in the playlist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ShowList[Show1, Show2, Show3...]</para>
        /// </summary>
        [NameInMap("ShowList")]
        [Validation(Required=false)]
        public string ShowList { get; set; }

        /// <summary>
        /// <para>The playlist.</para>
        /// </summary>
        [NameInMap("ShowListInfo")]
        [Validation(Required=false)]
        public DescribeShowListResponseBodyShowListInfo ShowListInfo { get; set; }
        public class DescribeShowListResponseBodyShowListInfo : TeaModel {
            /// <summary>
            /// <para>The background of the playlist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;MaterialId\&quot;:\&quot;a2b8e671-2fe5-4642-a2ec-bf93880e****\&quot;,\&quot;resourceType\&quot;:\&quot;VOD\&quot;}</para>
            /// </summary>
            [NameInMap("Background")]
            [Validation(Required=false)]
            public string Background { get; set; }

            /// <summary>
            /// <para>The ID of the show that is being played.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
            /// </summary>
            [NameInMap("CurrentShowId")]
            [Validation(Required=false)]
            public string CurrentShowId { get; set; }

            /// <summary>
            /// <para>The highest-priority show.</para>
            /// <remarks>
            /// <para>You can configure this parameter only before the playlist starts.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
            /// </summary>
            [NameInMap("HighPriorityShowId")]
            [Validation(Required=false)]
            public string HighPriorityShowId { get; set; }

            /// <summary>
            /// <para>The time when the highest-priority show is played. The format is yyyy-MM-dd\&quot;T\&quot;HH:mm:ss.</para>
            /// <remarks>
            /// <para>You can configure this parameter only before the playlist starts. After the configuration is complete, the system switches to the highest-priority show at the specified time.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-23T12:30:00</para>
            /// </summary>
            [NameInMap("HighPriorityShowStartTime")]
            [Validation(Required=false)]
            public string HighPriorityShowStartTime { get; set; }

            [NameInMap("ShowList")]
            [Validation(Required=false)]
            public DescribeShowListResponseBodyShowListInfoShowList ShowList { get; set; }
            public class DescribeShowListResponseBodyShowListInfoShowList : TeaModel {
                [NameInMap("Show")]
                [Validation(Required=false)]
                public List<DescribeShowListResponseBodyShowListInfoShowListShow> Show { get; set; }
                public class DescribeShowListResponseBodyShowListInfoShowListShow : TeaModel {
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                    [NameInMap("RepeatTimes")]
                    [Validation(Required=false)]
                    public int? RepeatTimes { get; set; }

                    [NameInMap("ResourceInfo")]
                    [Validation(Required=false)]
                    public DescribeShowListResponseBodyShowListInfoShowListShowResourceInfo ResourceInfo { get; set; }
                    public class DescribeShowListResponseBodyShowListInfoShowListShowResourceInfo : TeaModel {
                        [NameInMap("LiveInputType")]
                        [Validation(Required=false)]
                        public int? LiveInputType { get; set; }

                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }

                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                        [NameInMap("ResourceUrl")]
                        [Validation(Required=false)]
                        public string ResourceUrl { get; set; }

                    }

                    [NameInMap("ShowId")]
                    [Validation(Required=false)]
                    public string ShowId { get; set; }

                    [NameInMap("ShowName")]
                    [Validation(Required=false)]
                    public string ShowName { get; set; }

                }

            }

            /// <summary>
            /// <para>The default number of loops for the playlist. This value is always 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ShowListRepeatTimes")]
            [Validation(Required=false)]
            public int? ShowListRepeatTimes { get; set; }

            /// <summary>
            /// <para>The number of times the entire playlist is looped.</para>
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
