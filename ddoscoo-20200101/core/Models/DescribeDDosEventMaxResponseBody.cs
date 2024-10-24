// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventMaxResponseBody : TeaModel {
        /// <summary>
        /// <para>The peak of connection flood attacks. Unit: connections per seconds (CPS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1302</para>
        /// </summary>
        [NameInMap("Cps")]
        [Validation(Required=false)]
        public long? Cps { get; set; }

        /// <summary>
        /// <para>The peak of volumetric attacks. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6809</para>
        /// </summary>
        [NameInMap("Mbps")]
        [Validation(Required=false)]
        public long? Mbps { get; set; }

        /// <summary>
        /// <para>The peak of resource exhaustion attacks. Unit: queries per second (QPS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>26314</para>
        /// </summary>
        [NameInMap("Qps")]
        [Validation(Required=false)]
        public long? Qps { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5AE2FC86-C840-41AE-9F1A-3A2747C7C1DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
