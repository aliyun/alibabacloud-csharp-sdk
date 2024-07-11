// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeElasticQpsResponseBody : TeaModel {
        /// <summary>
        /// The information about the burstable QPS.
        /// </summary>
        [NameInMap("ElasticQps")]
        [Validation(Required=false)]
        public List<DescribeElasticQpsResponseBodyElasticQps> ElasticQps { get; set; }
        public class DescribeElasticQpsResponseBodyElasticQps : TeaModel {
            /// <summary>
            /// The index number of the returned data.
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// The peak QPS of the normal service.
            /// </summary>
            [NameInMap("MaxNormalQps")]
            [Validation(Required=false)]
            public long? MaxNormalQps { get; set; }

            /// <summary>
            /// The peak inbound QPS.
            /// </summary>
            [NameInMap("MaxQps")]
            [Validation(Required=false)]
            public long? MaxQps { get; set; }

            /// <summary>
            /// The total number of requests during the step size period.
            /// </summary>
            [NameInMap("Pv")]
            [Validation(Required=false)]
            public long? Pv { get; set; }

            /// <summary>
            /// The total number of HTTP 2xx status codes during the step size period.
            /// </summary>
            [NameInMap("Status2")]
            [Validation(Required=false)]
            public long? Status2 { get; set; }

            /// <summary>
            /// The total number of HTTP 3xx status codes during the step size period.
            /// </summary>
            [NameInMap("Status3")]
            [Validation(Required=false)]
            public long? Status3 { get; set; }

            /// <summary>
            /// The total number of HTTP 4xx status codes during the step size period.
            /// </summary>
            [NameInMap("Status4")]
            [Validation(Required=false)]
            public long? Status4 { get; set; }

            /// <summary>
            /// The total number of HTTP 5xx status codes during the step size period.
            /// </summary>
            [NameInMap("Status5")]
            [Validation(Required=false)]
            public long? Status5 { get; set; }

            /// <summary>
            /// The total number of origin requests during the step size period.
            /// </summary>
            [NameInMap("Ups")]
            [Validation(Required=false)]
            public long? Ups { get; set; }

        }

        /// <summary>
        /// The request ID, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
