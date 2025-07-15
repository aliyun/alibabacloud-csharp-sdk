// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamPreloadTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The details of the prefetch task.</para>
        /// </summary>
        [NameInMap("PreloadTasks")]
        [Validation(Required=false)]
        public DescribeLiveStreamPreloadTasksResponseBodyPreloadTasks PreloadTasks { get; set; }
        public class DescribeLiveStreamPreloadTasksResponseBodyPreloadTasks : TeaModel {
            [NameInMap("PreloadTask")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamPreloadTasksResponseBodyPreloadTasksPreloadTask> PreloadTask { get; set; }
            public class DescribeLiveStreamPreloadTasksResponseBodyPreloadTasksPreloadTask : TeaModel {
                /// <summary>
                /// <para>The acceleration region where the live content is prefetched. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>domestic: regions in the Chinese mainland.</description></item>
                /// <item><description>overseas: regions outside the Chinese mainland.</description></item>
                /// <item><description>global: regions in and outside the Chinese mainland.</description></item>
                /// </list>
                /// <remarks>
                /// <para> If this parameter is left empty, the acceleration region configured for the domain name is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>domestic</para>
                /// </summary>
                [NameInMap("Area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                /// <summary>
                /// <para>The time when the prefetch task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-06-29T19:00:00Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the prefetch task is successful. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Successfully</description></item>
                /// <item><description>InternalError</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Successfully</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The streaming domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The streaming URL.</para>
                /// </summary>
                [NameInMap("PlayUrl")]
                [Validation(Required=false)]
                public string PlayUrl { get; set; }

                /// <summary>
                /// <para>The time when the prefetch task ended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-06-30T19:00:00Z</para>
                /// </summary>
                [NameInMap("PreloadedEndTime")]
                [Validation(Required=false)]
                public string PreloadedEndTime { get; set; }

                /// <summary>
                /// <para>The time when the prefetch task started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016-06-29T19:00:00Z</para>
                /// </summary>
                [NameInMap("PreloadedStartTime")]
                [Validation(Required=false)]
                public string PreloadedStartTime { get; set; }

                /// <summary>
                /// <para>The progress of the prefetch task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100%</para>
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

                /// <summary>
                /// <para>The status of the prefetch task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Success</description></item>
                /// <item><description>Failed</description></item>
                /// </list>
                /// <remarks>
                /// <para> Success is returned only if the prefetch task is configured for all streaming URLs.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the prefetch task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourTaskId</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1564CBC-DCFE-5E1B-8B78-8DED9A39F334</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
