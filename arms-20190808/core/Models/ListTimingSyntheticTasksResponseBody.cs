// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListTimingSyntheticTasksResponseBody : TeaModel {
        /// <summary>
        /// The status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTimingSyntheticTasksResponseBodyData Data { get; set; }
        public class ListTimingSyntheticTasksResponseBodyData : TeaModel {
            /// <summary>
            /// The queried tasks.
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListTimingSyntheticTasksResponseBodyDataItems> Items { get; set; }
            public class ListTimingSyntheticTasksResponseBodyDataItems : TeaModel {
                [NameInMap("CommonSetting")]
                [Validation(Required=false)]
                public ListTimingSyntheticTasksResponseBodyDataItemsCommonSetting CommonSetting { get; set; }
                public class ListTimingSyntheticTasksResponseBodyDataItemsCommonSetting : TeaModel {
                    [NameInMap("CustomHost")]
                    [Validation(Required=false)]
                    public ListTimingSyntheticTasksResponseBodyDataItemsCommonSettingCustomHost CustomHost { get; set; }
                    public class ListTimingSyntheticTasksResponseBodyDataItemsCommonSettingCustomHost : TeaModel {
                        [NameInMap("Hosts")]
                        [Validation(Required=false)]
                        public List<ListTimingSyntheticTasksResponseBodyDataItemsCommonSettingCustomHostHosts> Hosts { get; set; }
                        public class ListTimingSyntheticTasksResponseBodyDataItemsCommonSettingCustomHostHosts : TeaModel {
                            [NameInMap("Domain")]
                            [Validation(Required=false)]
                            public string Domain { get; set; }

                            [NameInMap("IpType")]
                            [Validation(Required=false)]
                            public int? IpType { get; set; }

                            [NameInMap("Ips")]
                            [Validation(Required=false)]
                            public List<string> Ips { get; set; }

                        }

                        [NameInMap("SelectType")]
                        [Validation(Required=false)]
                        public int? SelectType { get; set; }

                    }

                    [NameInMap("CustomPrometheusSetting")]
                    [Validation(Required=false)]
                    public ListTimingSyntheticTasksResponseBodyDataItemsCommonSettingCustomPrometheusSetting CustomPrometheusSetting { get; set; }
                    public class ListTimingSyntheticTasksResponseBodyDataItemsCommonSettingCustomPrometheusSetting : TeaModel {
                        [NameInMap("PrometheusClusterId")]
                        [Validation(Required=false)]
                        public string PrometheusClusterId { get; set; }

                        [NameInMap("PrometheusClusterRegion")]
                        [Validation(Required=false)]
                        public string PrometheusClusterRegion { get; set; }

                        [NameInMap("PrometheusLabels")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> PrometheusLabels { get; set; }

                    }

                    [NameInMap("CustomVPCSetting")]
                    [Validation(Required=false)]
                    public ListTimingSyntheticTasksResponseBodyDataItemsCommonSettingCustomVPCSetting CustomVPCSetting { get; set; }
                    public class ListTimingSyntheticTasksResponseBodyDataItemsCommonSettingCustomVPCSetting : TeaModel {
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        [NameInMap("SecureGroupId")]
                        [Validation(Required=false)]
                        public string SecureGroupId { get; set; }

                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                    }

                    [NameInMap("IpType")]
                    [Validation(Required=false)]
                    public int? IpType { get; set; }

                    [NameInMap("IsOpenTrace")]
                    [Validation(Required=false)]
                    public bool? IsOpenTrace { get; set; }

                    [NameInMap("MonitorSamples")]
                    [Validation(Required=false)]
                    public int? MonitorSamples { get; set; }

                    [NameInMap("TraceClientType")]
                    [Validation(Required=false)]
                    public int? TraceClientType { get; set; }

                    [NameInMap("XtraceRegion")]
                    [Validation(Required=false)]
                    public string XtraceRegion { get; set; }

                }

                /// <summary>
                /// The detection frequency. Valid values: 1m, 5m, 10m, 15m, 20m, 30m, 1h, 2h, 3h, 4h, 6h, 8h, 12h, and 24h.
                /// </summary>
                [NameInMap("Frequency")]
                [Validation(Required=false)]
                public string Frequency { get; set; }

                /// <summary>
                /// The time when the task was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the task was modified.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The detection point type. 1: PC. 2: mobile device.
                /// </summary>
                [NameInMap("MonitorCategory")]
                [Validation(Required=false)]
                public int? MonitorCategory { get; set; }

                /// <summary>
                /// The number of detection points.
                /// </summary>
                [NameInMap("MonitorNum")]
                [Validation(Required=false)]
                public string MonitorNum { get; set; }

                /// <summary>
                /// The task name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The task status. CREATING: The task is being created. RUNNING: The task is running. PARTIAL_RUNNING: The task is partially running. STOP: The task is stopped. LIMIT_STOP: The task is stopped due to quota limit. EXCEPTION: The task is abnormal. DELETE: The task is deleted. DELETE_EXCEPTION: An exception occurs while deleting the task.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListTimingSyntheticTasksResponseBodyDataItemsTags> Tags { get; set; }
                public class ListTimingSyntheticTasksResponseBodyDataItemsTags : TeaModel {
                    /// <summary>
                    /// The tag key.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The tag value.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The ID of the synthetic monitoring task.
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// The type of the task. Valid values:
                /// 
                /// 1: ICMP. 2: TCP. 3: DNS. 4: HTTP. 5: website speed. 6: file download.
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public int? TaskType { get; set; }

                /// <summary>
                /// The URL for synthetic monitoring.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of tasks.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
