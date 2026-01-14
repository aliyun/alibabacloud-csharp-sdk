// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class BandwidthPackageAddAcceleratorResponseBody : TeaModel {
        /// <summary>
        /// <para>The GA instance IDs.</para>
        /// </summary>
        [NameInMap("Accelerators")]
        [Validation(Required=false)]
        public List<string> Accelerators { get; set; }

        /// <summary>
        /// <para>The bandwidth plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gbwp-bp1sgzldyj6b4q7cx****</para>
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B7770CB9-9745-4FE5-9EDA-D14B01A12A50</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
