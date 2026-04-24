// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class DescribeMetricMetaListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>264C3E89-XXXX-XXXX-XXXX-CE9C2196C7DC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("resources")]
        [Validation(Required=false)]
        public List<DescribeMetricMetaListResponseBodyResources> Resources { get; set; }
        public class DescribeMetricMetaListResponseBodyResources : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("dimensionDescription")]
            [Validation(Required=false)]
            public List<DescribeMetricMetaListResponseBodyResourcesDimensionDescription> DimensionDescription { get; set; }
            public class DescribeMetricMetaListResponseBodyResourcesDimensionDescription : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("dimensions")]
            [Validation(Required=false)]
            public List<string> Dimensions { get; set; }

            [NameInMap("labels")]
            [Validation(Required=false)]
            public Dictionary<string, string> Labels { get; set; }

            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("periods")]
            [Validation(Required=false)]
            public string Periods { get; set; }

            [NameInMap("statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6370</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
