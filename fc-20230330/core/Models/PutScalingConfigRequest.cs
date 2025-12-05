// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PutScalingConfigRequest : TeaModel {
        /// <summary>
        /// <para>The function scalability configuration.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public PutScalingConfigInput Body { get; set; }

        /// <summary>
        /// <para>The function alias.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
