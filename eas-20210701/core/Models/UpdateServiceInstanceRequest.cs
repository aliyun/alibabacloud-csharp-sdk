// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceInstanceRequest : TeaModel {
        [NameInMap("IsReplica")]
        [Validation(Required=false)]
        public bool? IsReplica { get; set; }

        [NameInMap("Detach")]
        [Validation(Required=false)]
        public bool? Detach { get; set; }

        [NameInMap("Hibernate")]
        [Validation(Required=false)]
        public bool? Hibernate { get; set; }

        /// <summary>
        /// <para>Specifies whether to isolate the service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Isolate")]
        [Validation(Required=false)]
        public bool? Isolate { get; set; }

    }

}
