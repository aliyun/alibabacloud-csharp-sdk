// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteResourceInstanceLabelRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the delete operation takes effect on all instances in the resource group. If you set this parameter to true, the InstanceIds parameter does not take effect.</para>
        /// </summary>
        [NameInMap("AllInstances")]
        [Validation(Required=false)]
        public bool? AllInstances { get; set; }

        /// <summary>
        /// <para>The instance IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The keys of the tags that you want to delete.</para>
        /// </summary>
        [NameInMap("Keys")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> Keys { get; set; }

        [NameInMap("LabelKeys")]
        [Validation(Required=false)]
        public List<string> LabelKeys { get; set; }

    }

}
