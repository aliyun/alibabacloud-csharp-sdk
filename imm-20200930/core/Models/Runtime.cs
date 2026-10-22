// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Runtime : TeaModel {
        /// <summary>
        /// <para>The hyperparameter information for the model training runtime.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Hyperparameters")]
        [Validation(Required=false)]
        public Hyperparameters Hyperparameters { get; set; }

        /// <summary>
        /// <para>The execution resource configuration information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public Resource Resource { get; set; }

    }

}
