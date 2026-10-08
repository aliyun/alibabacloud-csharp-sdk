// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeQuickSaleConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The commodity code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>rds: subscription</description></item>
        /// <item><description>bards: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public string Commodity { get; set; }

        /// <summary>
        /// <para>The commodity configuration details.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public Dictionary<string, object> Items { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>5DFFE9EC-3369-5937-A4E2-507C0C86A4C6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
