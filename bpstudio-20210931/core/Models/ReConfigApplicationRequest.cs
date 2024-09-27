// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class ReConfigApplicationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Q2P4O9YSOKCT35L9</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;${instance_type}&quot;:&quot;ecs.c6.3xlarge&quot;}</para>
        /// </summary>
        [NameInMap("Variables")]
        [Validation(Required=false)]
        public string Variables { get; set; }

    }

}
