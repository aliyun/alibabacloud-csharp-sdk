// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataDistResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The distribution status of data files on edge instances.</para>
        /// </summary>
        [NameInMap("DistResults")]
        [Validation(Required=false)]
        public DescribeDataDistResultResponseBodyDistResults DistResults { get; set; }
        public class DescribeDataDistResultResponseBodyDistResults : TeaModel {
            [NameInMap("DistResult")]
            [Validation(Required=false)]
            public List<DescribeDataDistResultResponseBodyDistResultsDistResult> DistResult { get; set; }
            public class DescribeDataDistResultResponseBodyDistResultsDistResult : TeaModel {
                /// <summary>
                /// <para>The name of the data file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gcs-prod-websocket-eip-unicom</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The distribution status statistics.</para>
                /// </summary>
                [NameInMap("StatusStats")]
                [Validation(Required=false)]
                public DescribeDataDistResultResponseBodyDistResultsDistResultStatusStats StatusStats { get; set; }
                public class DescribeDataDistResultResponseBodyDistResultsDistResultStatusStats : TeaModel {
                    [NameInMap("StatusStat")]
                    [Validation(Required=false)]
                    public List<DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStat> StatusStat { get; set; }
                    public class DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStat : TeaModel {
                        /// <summary>
                        /// <para>The number of associated edge instances.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("InstanceCount")]
                        [Validation(Required=false)]
                        public string InstanceCount { get; set; }

                        /// <summary>
                        /// <para>The distribution status of the edge instance.</para>
                        /// </summary>
                        [NameInMap("Instances")]
                        [Validation(Required=false)]
                        public DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStatInstances Instances { get; set; }
                        public class DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStatInstances : TeaModel {
                            [NameInMap("Instance")]
                            [Validation(Required=false)]
                            public List<DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStatInstancesInstance> Instance { get; set; }
                            public class DescribeDataDistResultResponseBodyDistResultsDistResultStatusStatsStatusStatInstancesInstance : TeaModel {
                                /// <summary>
                                /// <para>The ID of the instance</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>i-5qzje8f5un1wmi341m2yetaxv</para>
                                /// </summary>
                                [NameInMap("InstanceId")]
                                [Validation(Required=false)]
                                public string InstanceId { get; set; }

                                /// <summary>
                                /// <para>The start time of the distribution. The time is displayed in UTC.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2021-11-19T07:24:52Z</para>
                                /// </summary>
                                [NameInMap("StartTime")]
                                [Validation(Required=false)]
                                public string StartTime { get; set; }

                                /// <summary>
                                /// <para>The description of the distribution status.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>SUCCESS</para>
                                /// </summary>
                                [NameInMap("StatusDescrip")]
                                [Validation(Required=false)]
                                public string StatusDescrip { get; set; }

                                /// <summary>
                                /// <para>The time when the distribution status was last updated. The time is displayed in UTC.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2021-10-11T02:38:19Z</para>
                                /// </summary>
                                [NameInMap("UpdateTime")]
                                [Validation(Required=false)]
                                public string UpdateTime { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The distribution status. The value is of the enumeration type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>SUCCESS: The distribution is successful.</description></item>
                        /// <item><description>FAILED: The distribution failed.</description></item>
                        /// <item><description>DISTING: The data is being distributed.</description></item>
                        /// <item><description>POD_RESTARTING: The idle pod is being restarted.</description></item>
                        /// <item><description>DELETED: The data is cleared or removed.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>SUCCESS</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// <para>The version number of the data file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50373E71-7710-4620-8AAB-133CCE49451C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
