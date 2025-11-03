// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetArtifactBuildRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of the artifact. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ACCELERATED_IMAGE</c>: accelerated images.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACCELERATED_IMAGE</para>
        /// </summary>
        [NameInMap("ArtifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// <para>The ID of the artifact building rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crabr-o2670wqz2n70****</para>
        /// </summary>
        [NameInMap("BuildRuleId")]
        [Validation(Required=false)]
        public string BuildRuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Indicates whether the API request is successful. Valid values:</para>
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
        /// <para>Additional parameters.</para>
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
            /// <para>The list of files that you want to prefetch when you use the image acceleration feature. Each entry contains the Base64-encoded absolute path of a file.</para>
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
        /// <para>The ID of the effective range of the artifact building rule.</para>
        /// <list type="bullet">
        /// <item><description>The parameter value is the ID of the image repository.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>crr-8dz3aedjqlmk****</para>
        /// </summary>
        [NameInMap("ScopeId")]
        [Validation(Required=false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// <para>The effective range of the artifact building rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>REPOSITORY</c>: The artifact building rule is effective in the repository level.</description></item>
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
