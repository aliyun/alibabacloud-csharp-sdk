// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorNamespaceListResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The details of the namespaces.
        /// </summary>
        [NameInMap("DescribeHybridMonitorNamespace")]
        [Validation(Required=false)]
        public List<DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespace> DescribeHybridMonitorNamespace { get; set; }
        public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespace : TeaModel {
            /// <summary>
            /// The configuration details of metric import tasks for Alibaba Cloud services.
            /// </summary>
            [NameInMap("AliyunProductMetricList")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricList> AliyunProductMetricList { get; set; }
            public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricList : TeaModel {
                /// <summary>
                /// The namespaces.
                /// </summary>
                [NameInMap("NamespaceList")]
                [Validation(Required=false)]
                public List<DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricListNamespaceList> NamespaceList { get; set; }
                public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricListNamespaceList : TeaModel {
                    /// <summary>
                    /// The metrics for the Alibaba Cloud service.
                    /// </summary>
                    [NameInMap("MetricList")]
                    [Validation(Required=false)]
                    public List<DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricListNamespaceListMetricList> MetricList { get; set; }
                    public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricListNamespaceListMetricList : TeaModel {
                        /// <summary>
                        /// The metrics.
                        /// </summary>
                        [NameInMap("List")]
                        [Validation(Required=false)]
                        public List<string> List { get; set; }

                        /// <summary>
                        /// The collection period of the metric.
                        /// 
                        /// Unit: seconds.
                        /// </summary>
                        [NameInMap("Period")]
                        [Validation(Required=false)]
                        public long? Period { get; set; }

                    }

                    /// <summary>
                    /// The namespace for the Alibaba Cloud service.
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                }

                /// <summary>
                /// The account that is used to create the namespace.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// The configuration file of the Alibaba Cloud service that you want to monitor by using Hybrid Cloud Monitoring.
                /// 
                /// *   namespace: the namespace of the Alibaba Cloud service.
                /// *   metric_list: the metrics of the Alibaba Cloud service.
                /// *   dimension: the resources of the Alibaba Cloud service that you want to monitor by using Hybrid Cloud Monitoring. If you do not specify a dimension, all resources of the Alibaba Cloud service are monitored.
                /// </summary>
                [NameInMap("YAMLConfig")]
                [Validation(Required=false)]
                public string YAMLConfig { get; set; }

            }

            /// <summary>
            /// The timestamp that was generated when the namespace was created.
            /// 
            /// Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the namespace.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The details of the data retention period.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceDetail Detail { get; set; }
            public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceDetail : TeaModel {
                /// <summary>
                /// The region where the metric data is stored.
                /// 
                /// >  This parameter is returned if you select `m_prom_user` for `NamespaceType` when you create a namespace.
                /// </summary>
                [NameInMap("NamespaceRegion")]
                [Validation(Required=false)]
                public string NamespaceRegion { get; set; }

                /// <summary>
                /// The project where the metric data is located.
                /// 
                /// >  This parameter is returned if you select `m_prom_user` for `NamespaceType` when you create a namespace.
                /// </summary>
                [NameInMap("SLSProject")]
                [Validation(Required=false)]
                public string SLSProject { get; set; }

                /// <summary>
                /// The data retention period. Valid values:
                /// 
                /// *   cms.s1.large (Retention Period 15 Days)
                /// *   cms.s1.xlarge (Retention Period 32 Days)
                /// *   cms.s1.2xlarge (Retention Period 63 Days)
                /// *   cms.s1.3xlarge (Retention Period 93 Days)
                /// *   cms.s1.6xlarge (Retention Period 185 Days)
                /// *   cms.s1.12xlarge (Retention Period 367 Days)
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The ID of the namespace.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// Indicates whether the namespace is deleted. Valid values:
            /// 
            /// *   0: The namespace is not deleted.
            /// *   1: The namespace is deleted.
            /// </summary>
            [NameInMap("IsDelete")]
            [Validation(Required=false)]
            public int? IsDelete { get; set; }

            /// <summary>
            /// The timestamp that was generated when the namespace was last modified.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The name of the namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The storage scheme of metric data. Valid values:
            /// 
            /// *   m_prom_user: The metric data is stored in Simple Log Service.
            /// *   m_prom_pool: The metric data is stored in the storage space provided by CloudMonitor.
            /// </summary>
            [NameInMap("NamespaceType")]
            [Validation(Required=false)]
            public string NamespaceType { get; set; }

            /// <summary>
            /// The number of metric import tasks for third-party services.
            /// </summary>
            [NameInMap("NotAliyunTaskNumber")]
            [Validation(Required=false)]
            public long? NotAliyunTaskNumber { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
