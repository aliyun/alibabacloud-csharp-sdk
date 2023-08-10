// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeAppResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the version.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public DescribeAppResponseBodyResult Result { get; set; }
        public class DescribeAppResponseBodyResult : TeaModel {
            /// <summary>
            /// The ID of the created rough sort expression.
            /// </summary>
            [NameInMap("algoDeploymentId")]
            [Validation(Required=false)]
            public int? AlgoDeploymentId { get; set; }

            /// <summary>
            /// Indicates whether the version is automatically published to the online environment.
            /// </summary>
            [NameInMap("autoSwitch")]
            [Validation(Required=false)]
            public bool? AutoSwitch { get; set; }

            [NameInMap("clusterName")]
            [Validation(Required=false)]
            public string ClusterName { get; set; }

            /// <summary>
            /// The timestamp when the version was created.
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// The description of the version.
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("domain")]
            [Validation(Required=false)]
            public DescribeAppResponseBodyResultDomain Domain { get; set; }
            public class DescribeAppResponseBodyResultDomain : TeaModel {
                [NameInMap("category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("functions")]
                [Validation(Required=false)]
                public DescribeAppResponseBodyResultDomainFunctions Functions { get; set; }
                public class DescribeAppResponseBodyResultDomainFunctions : TeaModel {
                    [NameInMap("algo")]
                    [Validation(Required=false)]
                    public List<string> Algo { get; set; }

                    [NameInMap("qp")]
                    [Validation(Required=false)]
                    public List<string> Qp { get; set; }

                    [NameInMap("service")]
                    [Validation(Required=false)]
                    public List<string> Service { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The default display fields.
            /// </summary>
            [NameInMap("fetchFields")]
            [Validation(Required=false)]
            public List<string> FetchFields { get; set; }

            /// <summary>
            /// The ID of the version.
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The progress of data import, in percentage. For example, a value of 83 indicates 83%.
            /// </summary>
            [NameInMap("progressPercent")]
            [Validation(Required=false)]
            public int? ProgressPercent { get; set; }

            /// <summary>
            /// The quota information about the version.
            /// </summary>
            [NameInMap("quota")]
            [Validation(Required=false)]
            public DescribeAppResponseBodyResultQuota Quota { get; set; }
            public class DescribeAppResponseBodyResultQuota : TeaModel {
                /// <summary>
                /// The computing resources. Unit: logical computing units (LCUs).
                /// </summary>
                [NameInMap("computeResource")]
                [Validation(Required=false)]
                public int? ComputeResource { get; set; }

                /// <summary>
                /// The storage capacity. Unit: GB.
                /// </summary>
                [NameInMap("docSize")]
                [Validation(Required=false)]
                public int? DocSize { get; set; }

                /// <summary>
                /// The number of search requests per second. You are charged based on the number of search requests per second in the earlier billing model.
                /// </summary>
                [NameInMap("qps")]
                [Validation(Required=false)]
                public int? Qps { get; set; }

                /// <summary>
                /// The specifications of the application. Valid values:
                /// 
                /// *   opensearch.share.junior: basic
                /// *   opensearch.share.common: shared general-purpose
                /// *   opensearch.share.compute: shared computing
                /// *   opensearch.share.storage: shared storage
                /// *   opensearch.private.common: exclusive general-purpose
                /// *   opensearch.private.compute: exclusive computing
                /// *   opensearch.private.storage: exclusive storage
                /// </summary>
                [NameInMap("spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

            }

            /// <summary>
            /// The application schema.
            /// </summary>
            [NameInMap("schema")]
            [Validation(Required=false)]
            public Dictionary<string, object> Schema { get; set; }

            /// <summary>
            /// The status of the version. Valid values:
            /// 
            /// *   ok
            /// *   stopped
            /// *   frozen
            /// *   initializing
            /// *   unavailable
            /// *   data_waiting
            /// *   data_preparing
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The type of the application. Valid values:
            /// 
            /// *   standard: a standard application.
            /// *   advance: an advanced application which is of an old application type. New applications cannot be of this type.
            /// *   enhanced: an advanced application which is of a new application type.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
