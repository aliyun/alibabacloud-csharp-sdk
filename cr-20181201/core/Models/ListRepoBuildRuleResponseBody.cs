// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoBuildRuleResponseBody : TeaModel {
        /// <summary>
        /// The list of image building rules.
        /// </summary>
        [NameInMap("BuildRules")]
        [Validation(Required=false)]
        public List<ListRepoBuildRuleResponseBodyBuildRules> BuildRules { get; set; }
        public class ListRepoBuildRuleResponseBodyBuildRules : TeaModel {
            [NameInMap("BuildArgs")]
            [Validation(Required=false)]
            public List<string> BuildArgs { get; set; }

            /// <summary>
            /// The ID of the image building rule.
            /// </summary>
            [NameInMap("BuildRuleId")]
            [Validation(Required=false)]
            public string BuildRuleId { get; set; }

            /// <summary>
            /// The directory of the Dockerfile.
            /// </summary>
            [NameInMap("DockerfileLocation")]
            [Validation(Required=false)]
            public string DockerfileLocation { get; set; }

            /// <summary>
            /// The name of the Dockerfile.
            /// </summary>
            [NameInMap("DockerfileName")]
            [Validation(Required=false)]
            public string DockerfileName { get; set; }

            /// <summary>
            /// The tag of the image.
            /// </summary>
            [NameInMap("ImageTag")]
            [Validation(Required=false)]
            public string ImageTag { get; set; }

            [NameInMap("Platforms")]
            [Validation(Required=false)]
            public List<string> Platforms { get; set; }

            /// <summary>
            /// The name of the push that triggers the building rule.
            /// </summary>
            [NameInMap("PushName")]
            [Validation(Required=false)]
            public string PushName { get; set; }

            /// <summary>
            /// The type of the push that triggers the image building rule. Valid values:
            /// 
            /// *   GIT_BRANCH: branch push
            /// *   GIT_TAG: tag push
            /// </summary>
            [NameInMap("PushType")]
            [Validation(Required=false)]
            public string PushType { get; set; }

        }

        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   `true`: The request is successful.
        /// *   `false`: The request fails.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
