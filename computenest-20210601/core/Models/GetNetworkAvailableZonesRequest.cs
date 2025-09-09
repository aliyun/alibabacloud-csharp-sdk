// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class GetNetworkAvailableZonesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsPoc")]
        [Validation(Required=false)]
        public bool? IsPoc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("NetworkRegionId")]
        [Validation(Required=false)]
        public string NetworkRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PrivateLink</para>
        /// </summary>
        [NameInMap("PrivateVpcConnectionMode")]
        [Validation(Required=false)]
        public string PrivateVpcConnectionMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>service-55fc2eabbce647fa976b</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("ServiceInstanceEndpointServiceType")]
        [Validation(Required=false)]
        public string ServiceInstanceEndpointServiceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
