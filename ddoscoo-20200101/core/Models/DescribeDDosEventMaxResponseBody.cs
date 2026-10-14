// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventMaxResponseBody : TeaModel {
        /// <summary>
        /// <para>The peak attack throughput of connection flood attacks. Unit: cps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1302</para>
        /// </summary>
        [NameInMap("Cps")]
        [Validation(Required=false)]
        public long? Cps { get; set; }

        /// <summary>
        /// <para>The peak attack throughput of volumetric traffic attacks. Unit: Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6809</para>
        /// </summary>
        [NameInMap("Mbps")]
        [Validation(Required=false)]
        public long? Mbps { get; set; }

        /// <summary>
        /// <para>The peak attack throughput of web resource exhaustion attacks. Unit: qps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26314</para>
        /// </summary>
        [NameInMap("Qps")]
        [Validation(Required=false)]
        public long? Qps { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5AE2FC86-C840-41AE-9F1A-3A2747C7C1DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
