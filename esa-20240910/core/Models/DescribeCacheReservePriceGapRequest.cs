// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class DescribeCacheReservePriceGapRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>esa-cr-9tuv*********</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TargetQuotaGb")]
        [Validation(Required=false)]
        public long? TargetQuotaGb { get; set; }

    }

}
