// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class AssignLeniPrivateIpAddressRequest : TeaModel {
        /// <summary>
        /// <para>The idempotent identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3fd79d62-ab1d-11ec-9a53-0242ac110004</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wuhuaiyu</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Lingjun Elastic Network Interface ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>leni-1234****</para>
        /// </summary>
        [NameInMap("ElasticNetworkInterfaceId")]
        [Validation(Required=false)]
        public string ElasticNetworkInterfaceId { get; set; }

        /// <summary>
        /// <para>Lingjun Elastic Network Interface secondary private network IP (automatically assigned by default).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.****</para>
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

    }

}
