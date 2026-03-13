// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class InstanceLifecycleConfig : TeaModel {
        /// <summary>
        /// <para>The configurations of the Initializer hook.</para>
        /// </summary>
        [NameInMap("initializer")]
        [Validation(Required=false)]
        public LifecycleHook Initializer { get; set; }

        /// <summary>
        /// <para>The configurations of the PreStop hook.</para>
        /// </summary>
        [NameInMap("preStop")]
        [Validation(Required=false)]
        public LifecycleHook PreStop { get; set; }

    }

}
