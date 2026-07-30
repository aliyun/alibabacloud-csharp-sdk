// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class QueryCompenInfosForOpRequest : TeaModel {
        /// <summary>
        /// <para>The category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: flight</description></item>
        /// <item><description>2: hotel</description></item>
        /// <item><description>4: car service</description></item>
        /// <item><description>6: business travel train ticket</description></item>
        /// <item><description>11: international flight</description></item>
        /// <item><description>12: international hotel</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public int? Category { get; set; }

        /// <summary>
        /// <para>The compensation order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82508250249123456</para>
        /// </summary>
        [NameInMap("compen_id")]
        [Validation(Required=false)]
        public string CompenId { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1002086203277812345</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

    }

}
