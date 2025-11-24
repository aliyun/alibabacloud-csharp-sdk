// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class ModifyPilotEipResourceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>eip-hp36jpqq5eged********</para>
        /// </summary>
        [NameInMap("EipId")]
        [Validation(Required=false)]
        public string EipId { get; set; }

        /// <summary>
        /// <para>The type of the Istio Pilot with which you want to associate the EIPs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Bind an EIP to the Istio Pilot during canary release (only valid during the canary release).</description></item>
        /// <item><description><c>false</c>: Bind an EIP to the Istio Pilot in stable state.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsCanary")]
        [Validation(Required=false)]
        public bool? IsCanary { get; set; }

        /// <summary>
        /// <para>The type of the operation that you want to perform. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>UnBindEip</c>: unbinds an elastic IP address (EIP) from the Istio Pilot.</description></item>
        /// <item><description><c>BindEip</c>: binds an EIP to the Istio Pilot.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BindEip</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c1f5a67154bec40629c2698ec********</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
