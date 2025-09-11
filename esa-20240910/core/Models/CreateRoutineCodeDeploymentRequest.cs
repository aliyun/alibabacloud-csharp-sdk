// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateRoutineCodeDeploymentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CodeVersions")]
        [Validation(Required=false)]
        public List<CreateRoutineCodeDeploymentRequestCodeVersions> CodeVersions { get; set; }
        public class CreateRoutineCodeDeploymentRequestCodeVersions : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("CodeVersion")]
            [Validation(Required=false)]
            public string CodeVersion { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public long? Percentage { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>production</para>
        /// </summary>
        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
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
