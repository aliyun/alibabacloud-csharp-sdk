// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeTotalAttackMaxFlowResponseBody : TeaModel {
        /// <summary>
        /// <para>The peak bandwidth of attack traffic. Unit: bit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Bps")]
        [Validation(Required=false)]
        public long? Bps { get; set; }

        /// <summary>
        /// <para>The peak packet rate of attack traffic . Unit: packets per second (pps).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Pps")]
        [Validation(Required=false)]
        public long? Pps { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9173A3CB-C40B-559B-96B7-2373830BD06A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
