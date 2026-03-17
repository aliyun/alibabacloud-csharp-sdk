// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class GetCloudConnectNetworkUseLimitResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BCD04867-56C3-43DC-8FEF-923EFB8B56DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The maximum number of CCN instances that the current account can create in the specified region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalAmount")]
        [Validation(Required=false)]
        public int? TotalAmount { get; set; }

        /// <summary>
        /// <para>The number of CCN instances that you have created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("UsedAmount")]
        [Validation(Required=false)]
        public int? UsedAmount { get; set; }

    }

}
