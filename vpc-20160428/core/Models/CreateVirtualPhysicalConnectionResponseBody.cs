// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateVirtualPhysicalConnectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CD14EA74-E9C3-59A9-942A-DFEC7E12818D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the hosted connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1mrgfbtmc9brre7****</para>
        /// </summary>
        [NameInMap("VirtualPhysicalConnection")]
        [Validation(Required=false)]
        public string VirtualPhysicalConnection { get; set; }

    }

}
