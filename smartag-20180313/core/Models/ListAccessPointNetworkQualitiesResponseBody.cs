// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListAccessPointNetworkQualitiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The network quality of the endpoint.</para>
        /// </summary>
        [NameInMap("AccessPointNetworkQualities")]
        [Validation(Required=false)]
        public List<ListAccessPointNetworkQualitiesResponseBodyAccessPointNetworkQualities> AccessPointNetworkQualities { get; set; }
        public class ListAccessPointNetworkQualitiesResponseBodyAccessPointNetworkQualities : TeaModel {
            /// <summary>
            /// <para>The ID of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>115</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The packet loss rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.00%</para>
            /// </summary>
            [NameInMap("Loss")]
            [Validation(Required=false)]
            public string Loss { get; set; }

            /// <summary>
            /// <para>The network latency. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.98</para>
            /// </summary>
            [NameInMap("Rtt")]
            [Validation(Required=false)]
            public string Rtt { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8E8E8C86-1404-122A-A1BB-84BBC2E9A4B1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
