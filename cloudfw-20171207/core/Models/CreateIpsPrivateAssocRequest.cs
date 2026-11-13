// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateIpsPrivateAssocRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the Internet NAT gateway instance to be associated. This parameter is required. If this parameter is not specified, the ErrorParamsNotEnough error (HTTP 400, Parameters are insufficient.) is returned.</para>
        /// <remarks>
        /// <para>The backend does not verify the ID format. Instead, it queries the instance in the private network asset table of Cloud Firewall based on the current account. If the instance is not found, the ErrorParamsInvalid error (HTTP 400, Invalid Params) is returned. Common causes include: the resource type is not a NAT gateway, the resource is not managed by Cloud Firewall, or the asynchronous asset synchronization for a newly created NAT gateway is not completed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-c5vhmjdfp5t****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
