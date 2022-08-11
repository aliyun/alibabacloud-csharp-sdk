// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterResourcesResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=true)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public List<DescribeClusterResourcesResponseBody> Body { get; set; }
        public class DescribeClusterResourcesResponseBody : TeaModel {
            [NameInMap("cluster_id")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            [NameInMap("created")]
            [Validation(Required=false)]
            public string Created { get; set; }

            [NameInMap("instance_id")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("resource_info")]
            [Validation(Required=false)]
            public string ResourceInfo { get; set; }

            [NameInMap("resource_type")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("auto_create")]
            [Validation(Required=false)]
            public long? AutoCreate { get; set; }

        }

    }

}
