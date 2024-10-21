// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenBandwidthPackageResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the bandwidth plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cenbwp-4c2zaavbvh5fx****</para>
        /// </summary>
        [NameInMap("CenBandwidthPackageId")]
        [Validation(Required=false)]
        public string CenBandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The ID of the order for the bandwidth plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20156420004****</para>
        /// </summary>
        [NameInMap("CenBandwidthPackageOrderId")]
        [Validation(Required=false)]
        public string CenBandwidthPackageOrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E4B345CD-2CBA-4881-AF6D-E5D9BAE1CA7B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
