// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorNamespaceListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DescribeHybridMonitorNamespace")]
        [Validation(Required=false)]
        public List<DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespace> DescribeHybridMonitorNamespace { get; set; }
        public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespace : TeaModel {
            [NameInMap("AliyunProductMetricList")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricList> AliyunProductMetricList { get; set; }
            public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricList : TeaModel {
                [NameInMap("NamespaceList")]
                [Validation(Required=false)]
                public List<DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricListNamespaceList> NamespaceList { get; set; }
                public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceAliyunProductMetricListNamespaceList : TeaModel {
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

                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                [NameInMap("YAMLConfig")]
                [Validation(Required=false)]
                public string YAMLConfig { get; set; }

            }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Detail")]
            [Validation(Required=false)]
            public DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceDetail Detail { get; set; }
            public class DescribeHybridMonitorNamespaceListResponseBodyDescribeHybridMonitorNamespaceDetail : TeaModel {
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }
            };

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IsDelete")]
            [Validation(Required=false)]
            public int? IsDelete { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("NotAliyunTaskNumber")]
            [Validation(Required=false)]
            public long? NotAliyunTaskNumber { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
