// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class GetGlobalAcceleratorResourcesResponseBody : TeaModel {
        [NameInMap("AssociatedResources")]
        [Validation(Required=false)]
        public List<GetGlobalAcceleratorResourcesResponseBodyAssociatedResources> AssociatedResources { get; set; }
        public class GetGlobalAcceleratorResourcesResponseBodyAssociatedResources : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ga-bp1odcab8tmno0hdq****</para>
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Associated</para>
            /// </summary>
            [NameInMap("AssociatedMode")]
            [Validation(Required=false)]
            public string AssociatedMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>waf_v2_public_cn-x0r****gr1i</para>
            /// </summary>
            [NameInMap("AssociatedResourceId")]
            [Validation(Required=false)]
            public string AssociatedResourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("AssociatedResourceRegionId")]
            [Validation(Required=false)]
            public string AssociatedResourceRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>WAF</para>
            /// </summary>
            [NameInMap("AssociatedResourceType")]
            [Validation(Required=false)]
            public string AssociatedResourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>DE77A7F3-3B74-41C0-A5BC-CAFD188C28B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
