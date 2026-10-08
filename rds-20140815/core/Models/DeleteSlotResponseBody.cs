// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DeleteSlotResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2875D608-A228-53D7-B8C9-35F13EDCF36D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The replication slot name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slot_test01</para>
        /// </summary>
        [NameInMap("SlotName")]
        [Validation(Required=false)]
        public string SlotName { get; set; }

    }

}
