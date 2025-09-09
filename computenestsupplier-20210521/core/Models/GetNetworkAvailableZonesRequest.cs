// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
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
        /// <para>VirtualInternet</para>
        /// </summary>
        [NameInMap("PrivateVpcConnectionMode")]
        [Validation(Required=false)]
        public string PrivateVpcConnectionMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>service-63b8a060e9d54cxxxxxx</para>
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
        /// <para>draft</para>
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou-k</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
