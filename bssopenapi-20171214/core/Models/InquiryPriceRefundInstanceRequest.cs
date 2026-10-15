// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class InquiryPriceRefundInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Required for idempotent scenarios. A UUID-generated string. This field is used for idempotence. If the same value is passed in multiple calls, the result of the first call is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>793F021C-B589-1225-82A9-99232AEBE494</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Required for unsubscription scenarios. The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1etb69sqxgl4*******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Required for unsubscription scenarios. The product code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Required for unsubscription scenarios. The product type. Pass an empty string (&quot;&quot;) unless otherwise specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>”“</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

    }

}
