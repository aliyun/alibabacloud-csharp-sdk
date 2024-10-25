// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateLoadBalancerResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the ELB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5s7crik3yo3bp03gqrbp5****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The name of the ELB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gcs-pre-websocket-****</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// <para>The ID of the network.</para>
        /// 
        /// <b>Example:</b>
        /// <para>n-5sax03dh2eyagujgsn7z9****</para>
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ECC937A-AE0E-4626-BE51-DED1D6D1C888</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the ELB instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-5savh5ngxh8sbj14bu7n****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
