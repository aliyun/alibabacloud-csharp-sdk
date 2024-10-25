// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataPushResultResponseBody : TeaModel {
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
        /// <para>The push results of data files.</para>
        /// </summary>
        [NameInMap("PushResults")]
        [Validation(Required=false)]
        public DescribeDataPushResultResponseBodyPushResults PushResults { get; set; }
        public class DescribeDataPushResultResponseBodyPushResults : TeaModel {
            [NameInMap("PushResult")]
            [Validation(Required=false)]
            public List<DescribeDataPushResultResponseBodyPushResultsPushResult> PushResult { get; set; }
            public class DescribeDataPushResultResponseBodyPushResultsPushResult : TeaModel {
                /// <summary>
                /// <para>The name of the data file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gcs-pre-websocket-eip-telecom</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The push status of data files.</para>
                /// </summary>
                [NameInMap("StatusStatS")]
                [Validation(Required=false)]
                public DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatS StatusStatS { get; set; }
                public class DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatS : TeaModel {
                    [NameInMap("StatusStat")]
                    [Validation(Required=false)]
                    public List<DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStat> StatusStat { get; set; }
                    public class DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStat : TeaModel {
                        /// <summary>
                        /// <para>The total number of ENS nodes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("RegionIdCount")]
                        [Validation(Required=false)]
                        public int? RegionIdCount { get; set; }

                        /// <summary>
                        /// <para>The push status of data files on the ENS node.</para>
                        /// </summary>
                        [NameInMap("RegionIds")]
                        [Validation(Required=false)]
                        public DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStatRegionIds RegionIds { get; set; }
                        public class DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStatRegionIds : TeaModel {
                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public List<DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStatRegionIdsRegionId> RegionId { get; set; }
                            public class DescribeDataPushResultResponseBodyPushResultsPushResultStatusStatSStatusStatRegionIdsRegionId : TeaModel {
                                /// <summary>
                                /// <para>The ID of the ENS node.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>cn-wuxi-5</para>
                                /// </summary>
                                [NameInMap("RegionId")]
                                [Validation(Required=false)]
                                public string RegionId { get; set; }

                                /// <summary>
                                /// <para>The start time of the push operation. The time is displayed in UTC.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2021-12-28T16:00:00Z</para>
                                /// </summary>
                                [NameInMap("StartTime")]
                                [Validation(Required=false)]
                                public string StartTime { get; set; }

                                /// <summary>
                                /// <para>The description of the status.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>Success</para>
                                /// </summary>
                                [NameInMap("StatusDescrip")]
                                [Validation(Required=false)]
                                public string StatusDescrip { get; set; }

                                /// <summary>
                                /// <para>The time when the status was last updated. The time is displayed in UTC.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>2021-12-07T02:37:10Z</para>
                                /// </summary>
                                [NameInMap("UpdateTime")]
                                [Validation(Required=false)]
                                public string UpdateTime { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The push status. The value is of the enumeration type. Valid values: SUCCESS FAILED PUSHING</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FAILED</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

}
