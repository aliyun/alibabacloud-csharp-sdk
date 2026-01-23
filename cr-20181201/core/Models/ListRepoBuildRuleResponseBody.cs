// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListRepoBuildRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of image building rules.</para>
        /// </summary>
        [NameInMap("BuildRules")]
        [Validation(Required=false)]
        public List<ListRepoBuildRuleResponseBodyBuildRules> BuildRules { get; set; }
        public class ListRepoBuildRuleResponseBodyBuildRules : TeaModel {
            [NameInMap("BuildArgs")]
            [Validation(Required=false)]
            public List<string> BuildArgs { get; set; }

            /// <summary>
            /// <para>The ID of the image building rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>crbr-khys0nd3asbe****</para>
            /// </summary>
            [NameInMap("BuildRuleId")]
            [Validation(Required=false)]
            public string BuildRuleId { get; set; }

            [NameInMap("DestArtifactType")]
            [Validation(Required=false)]
            public string DestArtifactType { get; set; }

            /// <summary>
            /// <para>The directory of the Dockerfile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("DockerfileLocation")]
            [Validation(Required=false)]
            public string DockerfileLocation { get; set; }

            /// <summary>
            /// <para>The name of the Dockerfile.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dockerfile</para>
            /// </summary>
            [NameInMap("DockerfileName")]
            [Validation(Required=false)]
            public string DockerfileName { get; set; }

            /// <summary>
            /// <para>The tag of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v0.1</para>
            /// </summary>
            [NameInMap("ImageTag")]
            [Validation(Required=false)]
            public string ImageTag { get; set; }

            [NameInMap("Platforms")]
            [Validation(Required=false)]
            public List<string> Platforms { get; set; }

            /// <summary>
            /// <para>The name of the push that triggers the building rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v0.1</para>
            /// </summary>
            [NameInMap("PushName")]
            [Validation(Required=false)]
            public string PushName { get; set; }

            /// <summary>
            /// <para>The type of the push that triggers the image building rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>GIT_BRANCH: branch push</description></item>
            /// <item><description>GIT_TAG: tag push</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GIT_BRANCH</para>
            /// </summary>
            [NameInMap("PushType")]
            [Validation(Required=false)]
            public string PushType { get; set; }

        }

        /// <summary>
        /// <para>The return value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request is successful.</description></item>
        /// <item><description><c>false</c>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42D782C8-E8F6-4A32-BEA0-6A6AC854C22A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
