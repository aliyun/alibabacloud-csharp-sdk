// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Advisor20180120.Models
{
    public class DescribeAdvisorResourcesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAdvisorResourcesResponseBodyData Data { get; set; }
        public class DescribeAdvisorResourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public DescribeAdvisorResourcesResponseBodyDataResult Result { get; set; }
            public class DescribeAdvisorResourcesResponseBodyDataResult : TeaModel {
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public List<DescribeAdvisorResourcesResponseBodyDataResultResource> Resource { get; set; }
                public class DescribeAdvisorResourcesResponseBodyDataResultResource : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{
                    ///     &quot;resourceId&quot;: &quot;xxxxx&quot;,
                    ///     &quot;deviceAvailable&quot;: true,
                    ///     ...
                    /// }</para>
                    /// </summary>
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public string Data { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ecs</para>
                    /// </summary>
                    [NameInMap("Product")]
                    [Validation(Required=false)]
                    public string Product { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>i-bp67acfmxazb4p****</para>
                    /// </summary>
                    [NameInMap("ResourceId")]
                    [Validation(Required=false)]
                    public string ResourceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ecs-20230701</para>
                    /// </summary>
                    [NameInMap("ResourceName")]
                    [Validation(Required=false)]
                    public string ResourceName { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>566331F9-5AB3-550F-B745-A730331F97A9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
