// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagTrafficTopNResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AFF7E5A6-6897-4FDC-A5A8-1978B5B3E545</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of traffic rate information for Smart Access Gateway instances.</para>
        /// </summary>
        [NameInMap("TrafficTopN")]
        [Validation(Required=false)]
        public List<DescribeSagTrafficTopNResponseBodyTrafficTopN> TrafficTopN { get; set; }
        public class DescribeSagTrafficTopNResponseBodyTrafficTopN : TeaModel {
            /// <summary>
            /// <para>The instance ID of the Smart Access Gateway instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sag-whfn****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the Smart Access Gateway instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The region ID of the Smart Access Gateway instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The traffic rate of the Smart Access Gateway instance. Unit: bps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3866.6666666666665</para>
            /// </summary>
            [NameInMap("TrafficRate")]
            [Validation(Required=false)]
            public string TrafficRate { get; set; }

        }

    }

}
