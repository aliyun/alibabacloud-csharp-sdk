// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class GetArtifactBuildRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ACCELERATED_IMAGE</para>
        /// </summary>
        [NameInMap("ArtifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public GetArtifactBuildRuleResponseBodyParameters Parameters { get; set; }
        public class GetArtifactBuildRuleResponseBodyParameters : TeaModel {
            [NameInMap("ImageIndexOnly")]
            [Validation(Required=false)]
            public bool? ImageIndexOnly { get; set; }

            [NameInMap("PriorityFile")]
            [Validation(Required=false)]
            public string PriorityFile { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7A3E98F6-296C-54AC-A612-B75E7777D4C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>crr-8dz3aedjqlmk****</para>
        /// </summary>
        [NameInMap("ScopeId")]
        [Validation(Required=false)]
        public string ScopeId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>REPOSITORY</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

    }

}
