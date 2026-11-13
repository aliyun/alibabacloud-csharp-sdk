// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateModelOperatorServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the sales order generated when the model creation operator sub-service is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789012345</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the model operator service corresponding to the sales order. The return of this ID does not indicate that the service has been activated. You can call ListModelOperatorServices to query the subsequent status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>adbpg-mo-123456789abc</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

    }

}
