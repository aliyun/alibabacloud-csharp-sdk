// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoBuildRuleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        [NameInMap("BuildRules")]
        [Validation(Required=false)]
        public List<ListRepoBuildRuleResponseBodyBuildRules> BuildRules { get; set; }
        public class ListRepoBuildRuleResponseBodyBuildRules : TeaModel {
            [NameInMap("DockerfileLocation")]
            [Validation(Required=false)]
            public string DockerfileLocation { get; set; }

            [NameInMap("BuildRuleId")]
            [Validation(Required=false)]
            public string BuildRuleId { get; set; }

            [NameInMap("PushType")]
            [Validation(Required=false)]
            public string PushType { get; set; }

            [NameInMap("PushName")]
            [Validation(Required=false)]
            public string PushName { get; set; }

            [NameInMap("ImageTag")]
            [Validation(Required=false)]
            public string ImageTag { get; set; }

            [NameInMap("DockerfileName")]
            [Validation(Required=false)]
            public string DockerfileName { get; set; }

            [NameInMap("Platforms")]
            [Validation(Required=false)]
            public List<string> Platforms { get; set; }

            [NameInMap("BuildArgs")]
            [Validation(Required=false)]
            public List<string> BuildArgs { get; set; }

        }

    }

}
