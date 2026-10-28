// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ModelConfig : TeaModel {
        /// <summary>
        /// <para>The name of the output model. The output model of a joint training job is registered in the Models section of AI Asset Management under this name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model_a</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The model template configuration. This configuration is required if you want to deploy the output model to Elastic Algorithm Service (EAS) with one click.</para>
        /// </summary>
        [NameInMap("ModelTemplate")]
        [Validation(Required=false)]
        public ModelTemplate ModelTemplate { get; set; }

    }

}
