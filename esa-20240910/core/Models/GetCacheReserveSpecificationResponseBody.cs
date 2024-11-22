// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetCacheReserveSpecificationResponseBody : TeaModel {
        /// <summary>
        /// <para>The capacities of cache reserve instances that can be created.</para>
        /// </summary>
        [NameInMap("CacheReserveCapacity")]
        [Validation(Required=false)]
        public List<string> CacheReserveCapacity { get; set; }

        /// <summary>
        /// <para>The regions in which cache reserve instances can be created.</para>
        /// </summary>
        [NameInMap("CacheReserveRegion")]
        [Validation(Required=false)]
        public List<string> CacheReserveRegion { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEEBE525-F576-1196-8DAF-2D70CA3F4D2F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
