// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class GetNetworkAvailableZonesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the service is a trial service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsPoc")]
        [Validation(Required=false)]
        public bool? IsPoc { get; set; }

        /// <summary>
        /// <para>The region of the virtual Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("NetworkRegionId")]
        [Validation(Required=false)]
        public string NetworkRegionId { get; set; }

        /// <summary>
        /// <para>The connection mode. Valid values: \<c>PrivateLink\\</c> and \<c>OverlayLink\\</c>. \<c>OverlayLink\\</c> is an overlay link that is based on Application-aware Network Service Mesh (ANSM).</para>
        /// 
        /// <b>Example:</b>
        /// <para>VirtualInternet</para>
        /// </summary>
        [NameInMap("PrivateVpcConnectionMode")]
        [Validation(Required=false)]
        public string PrivateVpcConnectionMode { get; set; }

        /// <summary>
        /// <para>The service ID. This parameter is used with the \<c>IsPoc\\</c> parameter when \<c>IsPoc\\</c> is set to \<c>true\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-63b8a060e9d54cxxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The direction of the internal-facing access. Valid values: \<c>Forward\\</c> and \<c>Reverse\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("ServiceInstanceEndpointServiceType")]
        [Validation(Required=false)]
        public string ServiceInstanceEndpointServiceType { get; set; }

        /// <summary>
        /// <para>The region where the service is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>The service version. This parameter is used with the \<c>IsPoc\\</c> parameter when \<c>IsPoc\\</c> is set to \<c>true\\</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>draft</para>
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// <para>The zone where the service is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-k</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
