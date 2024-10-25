// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateDiskResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the instances.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The ID of the order. Multiple IDs are separated by commas (,).</para>
        /// <remarks>
        /// <para> This parameter is not returned for the pay-as-you-go billing method.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>21127020370****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7030AB96-57CF-1C68-9FEE-D60E547FD79C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
