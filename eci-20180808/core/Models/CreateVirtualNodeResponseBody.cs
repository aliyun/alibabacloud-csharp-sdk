// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class CreateVirtualNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>89164E78-FC82-4684-BE97-DCDD85D26546</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the VNode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vnd-2ze960zkdqrldeaw****</para>
        /// </summary>
        [NameInMap("VirtualNodeId")]
        [Validation(Required=false)]
        public string VirtualNodeId { get; set; }

    }

}
