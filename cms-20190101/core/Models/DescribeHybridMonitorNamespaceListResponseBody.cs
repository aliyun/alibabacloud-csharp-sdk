// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorNamespaceListResponseBody : TeaModel {
        /// <summary>
        /// The account that is used to create the namespace.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The metrics.
        /// </summary>
        [NameInMap("DescribeHybridMonitorNamespace")]
        [Validation(Required=false)]
        public List<DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespace> DescribeHybridMonitorNamespace { get; set; }
        public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespace : TeaModel {
            /// <summary>
            /// Indicates whether the namespace is deleted. Valid values:
            /// 
            /// *   0: The namespace is not deleted.
            /// *   1: The namespace is deleted.
            /// </summary>
            [NameInMap("AliyunProductMetricList")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricList> AliyunProductMetricList { get; set; }
            public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricList : TeaModel {
                /// <summary>
                /// The list of namespaces.
                /// </summary>
                [NameInMap("NamespaceList")]
                [Validation(Required=false)]
                public List<DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricListNamespaceList> NamespaceList { get; set; }
                public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricListNamespaceList : TeaModel {
                    /// <summary>
                    /// For more information about common request parameters, see [Common parameters](~~199331~~).
                    /// </summary>
                    [NameInMap("MetricList")]
                    [Validation(Required=false)]
                    public List<DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricListNamespaceListMetricList> MetricList { get; set; }
                    public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricListNamespaceListMetricList : TeaModel {
                        [NameInMap("List")]
                        [Validation(Required=false)]
                        public List<string> List { get; set; }

                        [NameInMap("Period")]
                        [Validation(Required=false)]
                        public long? Period { get; set; }

                    }

                    /// <summary>
                    /// The interval at which metrics are collected.
                    /// 
                    /// Unit: seconds.
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                [NameInMap("YAMLConfig")]
                [Validation(Required=false)]
                public string YAMLConfig { get; set; }

            }

            /// <summary>
            /// The keyword that is used to search for namespaces.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The number of metric import tasks for third-party services.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the namespace.
            /// 
            /// The name can contain uppercase letters, lowercase letters, digits, and hyphens (-).
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceDetail Detail { get; set; }
            public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceDetail : TeaModel {
                /// <summary>
                /// The page number of the returned page.
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The list of metrics for the Alibaba Cloud service.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The details of the data retention period.
            /// </summary>
            [NameInMap("IsDelete")]
            [Validation(Required=false)]
            public int? IsDelete { get; set; }

            /// <summary>
            /// The name of the namespace.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The configuration details of metric import tasks for Alibaba Cloud services.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("NotAliyunTaskNumber")]
            [Validation(Required=false)]
            public long? NotAliyunTaskNumber { get; set; }

        }

        /// <summary>
        /// The ID of the namespace.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The timestamp that was generated when the namespace was last modified.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// A minimum of 1 entry can be returned on each page. Default value: 10.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The namespace for the Alibaba Cloud service.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
