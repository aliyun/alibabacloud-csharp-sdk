// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateIpSetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The GA instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1yeeq8yfoyszmq****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The details about the acceleration regions.</para>
        /// </summary>
        [NameInMap("IpSets")]
        [Validation(Required=false)]
        public List<CreateIpSetsResponseBodyIpSets> IpSets { get; set; }
        public class CreateIpSetsResponseBodyIpSets : TeaModel {
            /// <summary>
            /// <para>The acceleration region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("AccelerateRegionId")]
            [Validation(Required=false)]
            public string AccelerateRegionId { get; set; }

            /// <summary>
            /// <para>The bandwidth allocated to the acceleration region. Unit: <b>Mbit/s</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The acceleration region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ips-bp11r5jb8ogp122xl****</para>
            /// </summary>
            [NameInMap("IpSetId")]
            [Validation(Required=false)]
            public string IpSetId { get; set; }

            /// <summary>
            /// <para>The line type of the EIP in the acceleration region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BGP</para>
            /// </summary>
            [NameInMap("IspType")]
            [Validation(Required=false)]
            public string IspType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1F4B6A4A-C89E-489E-BAF1-52777EE148EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
