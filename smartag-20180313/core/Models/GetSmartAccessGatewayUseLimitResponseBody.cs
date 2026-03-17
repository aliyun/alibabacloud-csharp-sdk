// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class GetSmartAccessGatewayUseLimitResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2265DB11-F5CC-496E-ADE7-D043AC37926A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of SAG instances that you can purchase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("TotalAmount")]
        [Validation(Required=false)]
        public int? TotalAmount { get; set; }

        /// <summary>
        /// <para>The number of SAG instances that you have purchased.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47</para>
        /// </summary>
        [NameInMap("UsedAmount")]
        [Validation(Required=false)]
        public int? UsedAmount { get; set; }

    }

}
