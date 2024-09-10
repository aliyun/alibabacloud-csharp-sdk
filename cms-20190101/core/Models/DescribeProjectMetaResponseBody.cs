// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeProjectMetaResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// 
        /// > The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the cloud service.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public DescribeProjectMetaResponseBodyResources Resources { get; set; }
        public class DescribeProjectMetaResponseBodyResources : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeProjectMetaResponseBodyResourcesResource> Resource { get; set; }
            public class DescribeProjectMetaResponseBodyResourcesResource : TeaModel {
                /// <summary>
                /// The description.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The tags. Tags are used to filter services.
                /// 
                /// Tags are returned in the following format: `[{"name":"Tag key","value":"Tag value"}, {"name":"Tag key","value":"Tag value"}]`. The following tags are commonly used:
                /// 
                /// *   alertUnit: the unit of the metric value in alerts. If the unit is small, the original metric value may be too large. In this case, you can use the `alertUnit` tag to specify an appropriate unit. This tag is used in CloudMonitor.
                /// *   minAlertPeriod: the minimum time interval to report a new alert. The interval at which monitoring data is reported. The value is usually 1 minute.
                /// *   metricCategory: the service specification. Example: kvstore_sharding. Some Alibaba Cloud services have multiple specifications that are defined in the same namespace. This parameter is used to identify the specifications.
                /// *   is_alarm: indicates whether an alert rule can be configured. We recommend that you do not use the special tags in the CloudMonitor console.
                /// </summary>
                [NameInMap("Labels")]
                [Validation(Required=false)]
                public string Labels { get; set; }

                /// <summary>
                /// The namespace of the cloud service. Format: `acs_Service name abbreviation`. For more information about namespaces, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values: true: The request was successful. false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
