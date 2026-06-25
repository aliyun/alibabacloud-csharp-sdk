// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteResourceInstanceLabelRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the operation takes effect on all instances in the resource group. If this parameter is set to true, the InstanceIds parameter does not take effect.</para>
        /// </summary>
        [NameInMap("AllInstances")]
        [Validation(Required=false)]
        public bool? AllInstances { get; set; }

        /// <summary>
        /// <para>The machine instance IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The tags to delete. (Deprecated. Use LabelKeys instead.).</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> Keys { get; set; }

        /// <summary>
        /// <para>The tags to delete.</para>
        /// </summary>
        [NameInMap("LabelKeys")]
        [Validation(Required=false)]
        public List<string> LabelKeys { get; set; }

    }

}
