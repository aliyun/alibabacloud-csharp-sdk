// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeQuickSaleConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The product code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>rds: The instance is a subscription instance.</description></item>
        /// <item><description>bards: The instance is a pay-as-you-go instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public string Commodity { get; set; }

        /// <summary>
        /// <para>The configuration details of the product.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public Dictionary<string, object> Items { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5DFFE9EC-3369-5937-A4E2-507C0C86A4C6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
