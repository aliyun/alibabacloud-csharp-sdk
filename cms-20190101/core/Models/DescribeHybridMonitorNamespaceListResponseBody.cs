// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorNamespaceListResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The details of the namespaces.</para>
        /// </summary>
        [NameInMap("DescribeHybridMonitorNamespace")]
        [Validation(Required=false)]
        public List<DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespace> DescribeHybridMonitorNamespace { get; set; }
        public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespace : TeaModel {
            /// <summary>
            /// <para>The configuration details of metric import tasks for Alibaba Cloud services.</para>
            /// </summary>
            [NameInMap("AliyunProductMetricList")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricList> AliyunProductMetricList { get; set; }
            public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricList : TeaModel {
                /// <summary>
                /// <para>The namespaces.</para>
                /// </summary>
                [NameInMap("NamespaceList")]
                [Validation(Required=false)]
                public List<DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricListNamespaceList> NamespaceList { get; set; }
                public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricListNamespaceList : TeaModel {
                    /// <summary>
                    /// <para>The metrics for the Alibaba Cloud service.</para>
                    /// </summary>
                    [NameInMap("MetricList")]
                    [Validation(Required=false)]
                    public List<DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricListNamespaceListMetricList> MetricList { get; set; }
                    public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricListNamespaceListMetricList : TeaModel {
                        /// <summary>
                        /// <para>The metrics.</para>
                        /// </summary>
                        [NameInMap("List")]
                        [Validation(Required=false)]
                        public List<string> List { get; set; }

                        /// <summary>
                        /// <para>The collection period of the metric.</para>
                        /// <para>Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("Period")]
                        [Validation(Required=false)]
                        public long? Period { get; set; }

                    }

                    /// <summary>
                    /// <para>The namespace for the Alibaba Cloud service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acs_ecs_dashboard</para>
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                }

                /// <summary>
                /// <para>The account that is used to create the namespace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120886317861****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// <para>The configuration file of the Alibaba Cloud service that you want to monitor by using Hybrid Cloud Monitoring.</para>
                /// <list type="bullet">
                /// <item><description>namespace: the namespace of the Alibaba Cloud service.</description></item>
                /// <item><description>metric_list: the metrics of the Alibaba Cloud service.</description></item>
                /// <item><description>dimension: the resources of the Alibaba Cloud service that you want to monitor by using Hybrid Cloud Monitoring. If you do not specify a dimension, all resources of the Alibaba Cloud service are monitored.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>products:- namespace: acs_ecs_dashboard metric_info: - metric_list: - cpu_total dimension: \&quot;\&quot;</para>
                /// </summary>
                [NameInMap("YAMLConfig")]
                [Validation(Required=false)]
                public string YAMLConfig { get; set; }

            }

            /// <summary>
            /// <para>The timestamp that was generated when the namespace was created.</para>
            /// <para>Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652682744000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The details of the data retention period.</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceDetail Detail { get; set; }
            public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceDetail : TeaModel {
                /// <summary>
                /// <para>The region where the metric data is stored.</para>
                /// <remarks>
                /// <para> This parameter is returned if you select <c>m_prom_user</c> for <c>NamespaceType</c> when you create a namespace.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("NamespaceRegion")]
                [Validation(Required=false)]
                public string NamespaceRegion { get; set; }

                /// <summary>
                /// <para>The project where the metric data is located.</para>
                /// <remarks>
                /// <para> This parameter is returned if you select <c>m_prom_user</c> for <c>NamespaceType</c> when you create a namespace.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>cms-hybrid-120886317861****-cn-hangzhou-a83d</para>
                /// </summary>
                [NameInMap("SLSProject")]
                [Validation(Required=false)]
                public string SLSProject { get; set; }

                /// <summary>
                /// <para>The data retention period. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cms.s1.large (Retention Period 15 Days)</description></item>
                /// <item><description>cms.s1.xlarge (Retention Period 32 Days)</description></item>
                /// <item><description>cms.s1.2xlarge (Retention Period 63 Days)</description></item>
                /// <item><description>cms.s1.3xlarge (Retention Period 93 Days)</description></item>
                /// <item><description>cms.s1.6xlarge (Retention Period 185 Days)</description></item>
                /// <item><description>cms.s1.12xlarge (Retention Period 367 Days)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cms.s1.3xlarge</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// <para>The ID of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the namespace is deleted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The namespace is not deleted.</description></item>
            /// <item><description>1: The namespace is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("IsDelete")]
            [Validation(Required=false)]
            public int? IsDelete { get; set; }

            /// <summary>
            /// <para>The timestamp that was generated when the namespace was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652682744000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun-test</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The storage scheme of metric data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>m_prom_user: The metric data is stored in Simple Log Service.</description></item>
            /// <item><description>m_prom_pool: The metric data is stored in the storage space provided by CloudMonitor.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>m_prom_user</para>
            /// </summary>
            [NameInMap("NamespaceType")]
            [Validation(Required=false)]
            public string NamespaceType { get; set; }

            /// <summary>
            /// <para>The number of metric import tasks for third-party services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NotAliyunTaskNumber")]
            [Validation(Required=false)]
            public long? NotAliyunTaskNumber { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter PageSize is not valid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1EC450A4-3221-5148-B77E-2827576CFE48</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
