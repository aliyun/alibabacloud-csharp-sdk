// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeCacheReservePriceRequest : TeaModel {
        /// <summary>
        /// <para>The cache reserve region.</para>
        /// <list type="bullet">
        /// <item><description><para>HK: Hong Kong (China)</para>
        /// </description></item>
        /// <item><description><para>CN: the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HK</para>
        /// </summary>
        [NameInMap("CrRegion")]
        [Validation(Required=false)]
        public string CrRegion { get; set; }

        /// <summary>
        /// <para>The purchase period. Unit: months.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The cache reserve specification. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>512000</para>
        /// </summary>
        [NameInMap("QuotaGb")]
        [Validation(Required=false)]
        public long? QuotaGb { get; set; }

    }

}
