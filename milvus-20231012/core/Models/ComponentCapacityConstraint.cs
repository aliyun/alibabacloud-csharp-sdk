// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Milvus20231012.Models
{
    public class ComponentCapacityConstraint : TeaModel {
        /// <summary>
        /// <para>The component type.</para>
        /// </summary>
        [NameInMap("componentType")]
        [Validation(Required=false)]
        public string ComponentType { get; set; }

        /// <summary>
        /// <para>The maximum capacity allowed for the component.</para>
        /// </summary>
        [NameInMap("maxCapacity")]
        [Validation(Required=false)]
        public int? MaxCapacity { get; set; }

        /// <summary>
        /// <para>The minimum capacity allowed for the component.</para>
        /// </summary>
        [NameInMap("minCapacity")]
        [Validation(Required=false)]
        public int? MinCapacity { get; set; }

    }

}
