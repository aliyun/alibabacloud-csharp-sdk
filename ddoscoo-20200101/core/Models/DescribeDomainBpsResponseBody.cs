// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainBpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The bandwidths.</para>
        /// </summary>
        [NameInMap("DomainBps")]
        [Validation(Required=false)]
        public List<DescribeDomainBpsResponseBodyDomainBps> DomainBps { get; set; }
        public class DescribeDomainBpsResponseBodyDomainBps : TeaModel {
            /// <summary>
            /// <para>The inbound bandwidth. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InBps")]
            [Validation(Required=false)]
            public long? InBps { get; set; }

            /// <summary>
            /// <para>The index number of the returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// <para>The outbound bandwidth. Unit: bit/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("OutBps")]
            [Validation(Required=false)]
            public long? OutBps { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C33EB3D5-AF96-43CA-9C7E-37A81BC06A1E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
