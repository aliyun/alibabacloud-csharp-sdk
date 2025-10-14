// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRoutineCodeDeploymentResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration list of the phased release version number.</para>
        /// </summary>
        [NameInMap("CodeVersions")]
        [Validation(Required=false)]
        public List<CreateRoutineCodeDeploymentResponseBodyCodeVersions> CodeVersions { get; set; }
        public class CreateRoutineCodeDeploymentResponseBodyCodeVersions : TeaModel {
            /// <summary>
            /// <para>The version of the code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723599747213377175</para>
            /// </summary>
            [NameInMap("CodeVersion")]
            [Validation(Required=false)]
            public string CodeVersion { get; set; }

            /// <summary>
            /// <para>The phased release ratio.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public long? Percentage { get; set; }

        }

        /// <summary>
        /// <para>The deployment record ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>234</para>
        /// </summary>
        [NameInMap("DeploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDBD3EB3-97DA-5465-AEF5-8DCA5DC5E395</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The phased release policy. The constant string is &quot;percentage&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>percentage</para>
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

    }

}
