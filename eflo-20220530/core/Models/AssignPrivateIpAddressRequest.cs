// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class AssignPrivateIpAddressRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to assign a mac address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AssignMac")]
        [Validation(Required=false)]
        public bool? AssignMac { get; set; }

        /// <summary>
        /// <para>By default, popApi is not ignored and idempotent</para>
        /// 
        /// <b>Example:</b>
        /// <para>3fd79d62-ab1d-11ec-9a53-0242ac110004</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the variable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the network interface controller.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lni-bp18exxqa2rvfn45e5pz</para>
        /// </summary>
        [NameInMap("NetworkInterfaceId")]
        [Validation(Required=false)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// <para>The secondary private IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.6.194</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The default value is false. If you set the value to true, the secondary private IP address application process can be accelerated.</para>
        /// <remarks>
        /// <para> For more information, submit a ticket.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SkipConfig")]
        [Validation(Required=false)]
        public bool? SkipConfig { get; set; }

        /// <summary>
        /// <para>It belongs to the Lingjun subnet.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>subnet-f3zfzmnc</para>
        /// </summary>
        [NameInMap("SubnetId")]
        [Validation(Required=false)]
        public string SubnetId { get; set; }

    }

}
