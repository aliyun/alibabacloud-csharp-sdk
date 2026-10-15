// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class RefundInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Required for idempotent scenarios. A UUID-generated string. This field is used for idempotence. If the same value is passed in multiple calls, the result of the first call is returned. If a result is returned after the call, you can parse the refund order ID, which indicates that the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>793F021C-B589-1225-82A9-99232AEBE494</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Required for unsubscription scenarios. Valid values: 1: immediately releases the instance. 0: stops the instance first based on the shutdown policy. Only some products support this value. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ImmediatelyRelease")]
        [Validation(Required=false)]
        public string ImmediatelyRelease { get; set; }

        /// <summary>
        /// <para>Required for unsubscription scenarios. The instance ID, not the custom name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1etb69sqxgl4*******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Required for unsubscription scenarios. The product code. If the error code returned after the call indicates that the product is not supported, submit a ticket to request that the cloud service enable this feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Required for unsubscription scenarios. The product type. Unless otherwise specified, pass an empty string. In the debugging tool, you do not need to manually enter a value. Hover over the input box, and a button labeled &quot;Enter empty string&quot; appears. Click this button. When initiating an unsubscription through code, pass an empty string &quot;&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Empty string</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
