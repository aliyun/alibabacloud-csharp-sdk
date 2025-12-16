// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerAppResourceCapacityResponseBody : TeaModel {
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<GetEdgeContainerAppResourceCapacityResponseBodyRegions> Regions { get; set; }
        public class GetEdgeContainerAppResourceCapacityResponseBodyRegions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>unicom</para>
            /// </summary>
            [NameInMap("Isp")]
            [Validation(Required=false)]
            public string Isp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>huadong</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public int? Replicas { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50423A7F-A83D-1E24-B80E-86DD25790759</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
