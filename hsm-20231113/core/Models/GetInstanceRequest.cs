// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hsm20231113.Models
{
    public class GetInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the HSM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hsm-cn-vj30bil****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
