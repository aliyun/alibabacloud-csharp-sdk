// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetErServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The billing mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>er_paymode: billed for customers on the China site.</description></item>
        /// <item><description>er_freemode: free for customers on the China site.</description></item>
        /// <item><description>er_paymodeintl: billed for customers on the International site.</description></item>
        /// <item><description>err_freemodeintl: free for customers on the International site</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>er_paymode</para>
        /// </summary>
        [NameInMap("PlanName")]
        [Validation(Required=false)]
        public string PlanName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-A198-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>NotOpened</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
