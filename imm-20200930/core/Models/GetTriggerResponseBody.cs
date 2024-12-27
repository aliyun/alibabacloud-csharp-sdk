// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetTriggerResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A7A2D0E-D8B8-4DA0-8127-EB32C6******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The trigger information.</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public DataIngestion Trigger { get; set; }

    }

}
