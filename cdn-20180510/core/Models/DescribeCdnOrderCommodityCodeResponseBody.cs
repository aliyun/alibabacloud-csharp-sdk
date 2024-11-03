// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnOrderCommodityCodeResponseBody : TeaModel {
        /// <summary>
        /// <para>The commodity code that includes the organization unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("OrderCommodityCode")]
        [Validation(Required=false)]
        public string OrderCommodityCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BFFCDFAD-DACC-484E-9BE6-0AF3B3A0DD23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
