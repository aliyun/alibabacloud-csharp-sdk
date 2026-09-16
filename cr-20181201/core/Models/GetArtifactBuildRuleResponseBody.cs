// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetArtifactBuildRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of the accelerated image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ACCELERATED_IMAGE</c>: generates an accelerated image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACCELERATED_IMAGE</para>
        /// </summary>
        [NameInMap("ArtifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// <para>The build rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crabr-o2670wqz2n70****</para>
        /// </summary>
        [NameInMap("BuildRuleId")]
        [Validation(Required=false)]
        public string BuildRuleId { get; set; }

        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>200</b>: success.</description></item>
        /// <item><description>Other values: error codes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: The API call is successful.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: The API call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// <para>The additional parameters.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public GetArtifactBuildRuleResponseBodyParameters Parameters { get; set; }
        public class GetArtifactBuildRuleResponseBodyParameters : TeaModel {
            /// <summary>
            /// <para>Indicates whether the index-only mode is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ImageIndexOnly")]
            [Validation(Required=false)]
            public bool? ImageIndexOnly { get; set; }

            /// <summary>
            /// <para>The task priority. Valid values: [1, 5].</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The list of prefetch files for the accelerated image. Each line contains an absolute path. The list is Base64-encoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>L2hvbWUvdGVzdC8=</para>
            /// </summary>
            [NameInMap("PriorityFile")]
            [Validation(Required=false)]
            public string PriorityFile { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7A3E98F6-296C-54AC-A612-B75E7777D4C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the scope in which the rule takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ScopeId: the image repository ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>crr-8dz3aedjqlmk****</para>
        /// </summary>
        [NameInMap("ScopeId")]
        [Validation(Required=false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// <para>The scope of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>REPOSITORY</c>: repository level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>REPOSITORY</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
