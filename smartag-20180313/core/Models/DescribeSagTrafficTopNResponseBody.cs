// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagTrafficTopNResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AFF7E5A6-6897-4FDC-A5A8-1978B5B3E545</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the data transfer rate of the SAG instance.</para>
        /// </summary>
        [NameInMap("TrafficTopN")]
        [Validation(Required=false)]
        public List<DescribeSagTrafficTopNResponseBodyTrafficTopN> TrafficTopN { get; set; }
        public class DescribeSagTrafficTopNResponseBodyTrafficTopN : TeaModel {
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

            /// <summary>
            /// <para>The data transfer rate of the SAG instance. Unit: bit/s</para>
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
