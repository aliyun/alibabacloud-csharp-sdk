// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRoutineCodeDeploymentRequest : TeaModel {
        /// <summary>
        /// <para>The list of percentage-based canary release version configurations. A maximum of two versions are supported, and the total percentage must equal 100.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CodeVersions")]
        [Validation(Required=false)]
        public List<CreateRoutineCodeDeploymentRequestCodeVersions> CodeVersions { get; set; }
        public class CreateRoutineCodeDeploymentRequestCodeVersions : TeaModel {
            /// <summary>
            /// <para>The code version number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723599747213377175</para>
            /// </summary>
            [NameInMap("CodeVersion")]
            [Validation(Required=false)]
            public string CodeVersion { get; set; }

            /// <summary>
            /// <para>The canary release percentage for the code version. Valid values: 1 to 100.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public long? Percentage { get; set; }

        }

        /// <summary>
        /// <para>The environment name.<br>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>staging</c>: staging environment </description></item>
        /// <item><description><c>production</c>: production environment</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>staging</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>The name of the Edge Function Routine.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The deployment strategy.<br>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>percentage</c>: percentage mode</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>percentage</para>
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

    }

}
