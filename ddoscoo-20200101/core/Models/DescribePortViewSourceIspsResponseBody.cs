// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortViewSourceIspsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request source ISP information of the Anti-DDoS Pro or Anti-DDoS Premium instance.</para>
        /// </summary>
        [NameInMap("Isps")]
        [Validation(Required=false)]
        public List<DescribePortViewSourceIspsResponseBodyIsps> Isps { get; set; }
        public class DescribePortViewSourceIspsResponseBodyIsps : TeaModel {
            /// <summary>
            /// <para>The relative number of requests.</para>
            /// <remarks>
            /// <para>This value does not represent the actual number of requests. You can use this value to calculate the proportion of requests from different ISPs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3390671</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The ISP ID. For more information, see the ISP code table below the response parameters. The ISP ID corresponds to the code in the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100017</para>
            /// </summary>
            [NameInMap("IspId")]
            [Validation(Required=false)]
            public string IspId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C33EB3D5-AF96-43CA-9C7E-37A81BC06A1E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
