// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateRenderingInstanceRequest : TeaModel {
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public CreateRenderingInstanceRequestAttributes Attributes { get; set; }
        public class CreateRenderingInstanceRequestAttributes : TeaModel {
            [NameInMap("EdgeMediaService")]
            [Validation(Required=false)]
            public string EdgeMediaService { get; set; }

            [NameInMap("InAccess")]
            [Validation(Required=false)]
            public string InAccess { get; set; }

            [NameInMap("OutAccess")]
            [Validation(Required=false)]
            public string OutAccess { get; set; }

            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("ClientInfo")]
        [Validation(Required=false)]
        public CreateRenderingInstanceRequestClientInfo ClientInfo { get; set; }
        public class CreateRenderingInstanceRequestClientInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>172.21.128.110</para>
            /// </summary>
            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

        }

        [NameInMap("InstanceBillingCycle")]
        [Validation(Required=false)]
        public string InstanceBillingCycle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>95BandwidthByMonth</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InternetMaxBandwidth")]
        [Validation(Required=false)]
        public long? InternetMaxBandwidth { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>crs.cp.l1</para>
        /// </summary>
        [NameInMap("RenderingSpec")]
        [Validation(Required=false)]
        public string RenderingSpec { get; set; }

        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public string StorageSize { get; set; }

    }

}
