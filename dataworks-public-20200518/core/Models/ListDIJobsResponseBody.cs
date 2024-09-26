// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDIJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("DIJobPaging")]
        [Validation(Required=false)]
        public ListDIJobsResponseBodyDIJobPaging DIJobPaging { get; set; }
        public class ListDIJobsResponseBodyDIJobPaging : TeaModel {
            /// <summary>
            /// <para>The list of tasks.</para>
            /// </summary>
            [NameInMap("DIJobs")]
            [Validation(Required=false)]
            public List<ListDIJobsResponseBodyDIJobPagingDIJobs> DIJobs { get; set; }
            public class ListDIJobsResponseBodyDIJobPagingDIJobs : TeaModel {
                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16626</para>
                /// </summary>
                [NameInMap("DIJobId")]
                [Validation(Required=false)]
                public long? DIJobId { get; set; }

                /// <summary>
                /// <para>The type of the destination. The value Hologres is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Hologres</para>
                /// </summary>
                [NameInMap("DestinationDataSourceType")]
                [Validation(Required=false)]
                public string DestinationDataSourceType { get; set; }

                /// <summary>
                /// <para>The task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql_to_holo_sync_8772</para>
                /// </summary>
                [NameInMap("JobName")]
                [Validation(Required=false)]
                public string JobName { get; set; }

                /// <summary>
                /// <para>The task status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Finished</description></item>
                /// <item><description>Initialized</description></item>
                /// <item><description>Stopped</description></item>
                /// <item><description>Failed</description></item>
                /// <item><description>Running</description></item>
                /// <item><description>Stopping</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("JobStatus")]
                [Validation(Required=false)]
                public string JobStatus { get; set; }

                /// <summary>
                /// <para>The synchronization type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>FullAndRealtimeIncremental: one-time full synchronization and real-time incremental synchronization</description></item>
                /// <item><description>RealtimeIncremental: real-time incremental synchronization</description></item>
                /// <item><description>Full: one-time full synchronization</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Full</para>
                /// </summary>
                [NameInMap("MigrationType")]
                [Validation(Required=false)]
                public string MigrationType { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1967</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The type of the source. The value MySQL is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("SourceDataSourceType")]
                [Validation(Required=false)]
                public string SourceDataSourceType { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7263E4AC-9D2E-5B29-B8AF-7C5012E92A41</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
