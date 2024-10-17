// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class OperationStateChangeReason : TeaModel {
        /// <summary>
        /// <para>状态码。</para>
        /// 
        /// <b>Example:</b>
        /// <para>OutOfStock</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>状态变化信息。</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource is sold out in the specified zone, try other types of resources or other regions and zones.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
