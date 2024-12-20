// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class StartMicroOutboundResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;caseId\&quot;:2323****}</para>
        /// </summary>
        [NameInMap("CustomerInfo")]
        [Validation(Required=false)]
        public string CustomerInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8883f165-4a0d-4da2-a2d2</para>
        /// </summary>
        [NameInMap("InvokeCmdId")]
        [Validation(Required=false)]
        public string InvokeCmdId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2019-05-23 17:30:32.525</para>
        /// </summary>
        [NameInMap("InvokeCreateTime")]
        [Validation(Required=false)]
        public string InvokeCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
