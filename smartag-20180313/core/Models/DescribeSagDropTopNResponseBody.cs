// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagDropTopNResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about packets dropped by the SAG instance.</para>
        /// </summary>
        [NameInMap("DropTopN")]
        [Validation(Required=false)]
        public List<DescribeSagDropTopNResponseBodyDropTopN> DropTopN { get; set; }
        public class DescribeSagDropTopNResponseBodyDropTopN : TeaModel {
            /// <summary>
            /// <para>The packet loss rate of the SAG instance. Unit: packets per second (PPS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0</para>
            /// </summary>
            [NameInMap("DropRate")]
            [Validation(Required=false)]
            public string DropRate { get; set; }

            /// <summary>
            /// <para>The ID of the SAG instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sag-whfn****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the SAG instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the region where the SAG instance is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AFF7E5A6-6897-4FDC-A5A8-1978B5B3E545</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
