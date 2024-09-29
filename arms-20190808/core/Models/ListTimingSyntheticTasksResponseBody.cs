// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListTimingSyntheticTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTimingSyntheticTasksResponseBodyData Data { get; set; }
        public class ListTimingSyntheticTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The queried tasks.</para>
            /// </summary>
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<ListTimingSyntheticTasksResponseBodyDataItems> Items { get; set; }
            public class ListTimingSyntheticTasksResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The general settings.</para>
                /// </summary>
                [NameInMap("CommonSetting")]
                [Validation(Required=false)]
                public ListTimingSyntheticTasksResponseBodyDataItemsCommonSetting CommonSetting { get; set; }
                public class ListTimingSyntheticTasksResponseBodyDataItemsCommonSetting : TeaModel {
                    /// <summary>
                    /// <para>The custom host settings.</para>
                    /// </summary>
                    [NameInMap("CustomHost")]
                    [Validation(Required=false)]
                    public ListTimingSyntheticTasksResponseBodyDataItemsCommonSettingCustomHost CustomHost { get; set; }
                    public class ListTimingSyntheticTasksResponseBodyDataItemsCommonSettingCustomHost : TeaModel {
                        /// <summary>
                        /// <para>The custom host settings.</para>
                        /// </summary>
                        [NameInMap("Hosts")]
                        [Validation(Required=false)]
                        public List<ListTimingSyntheticTasksResponseBodyDataItemsCommonSettingCustomHostHosts> Hosts { get; set; }
                        public class ListTimingSyntheticTasksResponseBodyDataItemsCommonSettingCustomHostHosts : TeaModel {
                            /// <summary>
                            /// <para>The destination domain name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
                            /// </summary>
                            [NameInMap("Domain")]
                            [Validation(Required=false)]
                            public string Domain { get; set; }

                            /// <summary>
                            /// <para>The IP version. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>0: A version is automatically selected.</description></item>
                            /// <item><description>1: IPv4.</description></item>
                            /// <item><description>2: IPv6.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("IpType")]
                            [Validation(Required=false)]
                            public int? IpType { get; set; }

                            /// <summary>
                            /// <para>The IP address.</para>
                            /// </summary>
                            [NameInMap("Ips")]
                            [Validation(Required=false)]
                            public List<string> Ips { get; set; }

                        }

                        /// <summary>
                        /// <para>The selection mode. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>0: random</description></item>
                        /// <item><description>1: polling</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("SelectType")]
                        [Validation(Required=false)]
                        public int? SelectType { get; set; }

                    }

                    /// <summary>
                    /// <para>A reserved field.</para>
                    /// </summary>
                    [NameInMap("CustomPrometheusSetting")]
                    [Validation(Required=false)]
                    public ListTimingSyntheticTasksResponseBodyDataItemsCommonSettingCustomPrometheusSetting CustomPrometheusSetting { get; set; }
                    public class ListTimingSyntheticTasksResponseBodyDataItemsCommonSettingCustomPrometheusSetting : TeaModel {
                        /// <summary>
                        /// <para>A reserved field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Reserved field</para>
                        /// </summary>
                        [NameInMap("PrometheusClusterId")]
                        [Validation(Required=false)]
                        public string PrometheusClusterId { get; set; }

                        /// <summary>
                        /// <para>A reserved field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Reserved field</para>
                        /// </summary>
                        [NameInMap("PrometheusClusterRegion")]
                        [Validation(Required=false)]
                        public string PrometheusClusterRegion { get; set; }

                        /// <summary>
                        /// <para>A reserved field.</para>
                        /// </summary>
                        [NameInMap("PrometheusLabels")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> PrometheusLabels { get; set; }

                    }

                    /// <summary>
                    /// <para>The information about the virtual private cloud (VPC). If the destination URL is an Alibaba Cloud internal endpoint, you need to configure a VPC.</para>
                    /// </summary>
                    [NameInMap("CustomVPCSetting")]
                    [Validation(Required=false)]
                    public ListTimingSyntheticTasksResponseBodyDataItemsCommonSettingCustomVPCSetting CustomVPCSetting { get; set; }
                    public class ListTimingSyntheticTasksResponseBodyDataItemsCommonSettingCustomVPCSetting : TeaModel {
                        /// <summary>
                        /// <para>The region ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-zhangjiakou</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The ID of the security group to which the client belongs. The security group specifies the inbound and outbound rules of the client for the VPC. You need to allow the security group to which the client belongs to access the security group to which the VPC belongs. Otherwise, the client cannot access resources in the VPC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sg-xxxxxxxxxxxxxx</para>
                        /// </summary>
                        [NameInMap("SecureGroupId")]
                        [Validation(Required=false)]
                        public string SecureGroupId { get; set; }

                        /// <summary>
                        /// <para>The vSwitch ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-bp1bcmj81kxxxxxxx</para>
                        /// </summary>
                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        /// <summary>
                        /// <para>The VPC ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-2zehbd4dfzahxxxxxxx</para>
                        /// </summary>
                        [NameInMap("VpcId")]
                        [Validation(Required=false)]
                        public string VpcId { get; set; }

                    }

                    /// <summary>
                    /// <para>The IP version. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: A version is automatically selected.</description></item>
                    /// <item><description>1: IPv4.</description></item>
                    /// <item><description>2: IPv6.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("IpType")]
                    [Validation(Required=false)]
                    public int? IpType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether tracing is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsOpenTrace")]
                    [Validation(Required=false)]
                    public bool? IsOpenTrace { get; set; }

                    /// <summary>
                    /// <para>Indicates whether monitoring samples are evenly distributed. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: No</description></item>
                    /// <item><description>1: Yes</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MonitorSamples")]
                    [Validation(Required=false)]
                    public int? MonitorSamples { get; set; }

                    /// <summary>
                    /// <para>The type of the client for tracing. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: ARMS agent</description></item>
                    /// <item><description>1: OpenTelemetry</description></item>
                    /// <item><description>2: Jaeger</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TraceClientType")]
                    [Validation(Required=false)]
                    public int? TraceClientType { get; set; }

                    /// <summary>
                    /// <para>The region to which trace data is reported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("XtraceRegion")]
                    [Validation(Required=false)]
                    public string XtraceRegion { get; set; }

                }

                /// <summary>
                /// <para>The detection frequency. Valid values: 1m, 5m, 10m, 15m, 20m, 30m, 1h, 2h, 3h, 4h, 6h, 8h, 12h, and 24h.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1m</para>
                /// </summary>
                [NameInMap("Frequency")]
                [Validation(Required=false)]
                public string Frequency { get; set; }

                /// <summary>
                /// <para>The time when the task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1671454758000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the task was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1673085633000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The detection point type. 1: PC. 2: mobile device.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MonitorCategory")]
                [Validation(Required=false)]
                public int? MonitorCategory { get; set; }

                /// <summary>
                /// <para>The number of detection points.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MonitorNum")]
                [Validation(Required=false)]
                public string MonitorNum { get; set; }

                /// <summary>
                /// <para>The task name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AlibabaCloud DNS Task</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aekzgwtq5vxxxxx</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The task status. CREATING: The task is being created. RUNNING: The task is running. PARTIAL_RUNNING: The task is partially running. STOP: The task is stopped. LIMIT_STOP: The task is stopped due to quota limit. EXCEPTION: The task is abnormal. DELETE: The task is deleted. DELETE_EXCEPTION: An exception occurs while deleting the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListTimingSyntheticTasksResponseBodyDataItemsTags> Tags { get; set; }
                public class ListTimingSyntheticTasksResponseBodyDataItemsTags : TeaModel {
                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>value</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The ID of the synthetic monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5308a2691f59422c8c3b7aeccec9cd3b</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The type of the task. Valid values:</para>
                /// <para>1: ICMP. 2: TCP. 3: DNS. 4: HTTP. 5: website speed. 6: file download.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public int? TaskType { get; set; }

                /// <summary>
                /// <para>The URL for synthetic monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.example.com">https://www.example.com</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public int? Page { get; set; }

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
            /// <para>The total number of tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>730E90FE-996A-5638-99F3-4F0F9038CC6C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
