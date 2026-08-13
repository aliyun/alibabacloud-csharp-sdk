// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateIpsPrivateAssocRequest : TeaModel {
        /// <summary>
        /// <para>The language of the request and response messages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the Internet NAT gateway instance to associate. This parameter is required. If this parameter is not specified, ErrorParamsNotEnough is returned (HTTP 400, Parameters are insufficient.).</para>
        /// <remarks>
        /// <para>The backend does not validate the ID format. Instead, it queries the instance in the Cloud Firewall private network asset table for the current account. If the instance is not found, ErrorParamsInvalid is returned (HTTP 400, Invalid Params). Common scenarios include the resource type not being a NAT gateway, the resource not being managed by Cloud Firewall, or a newly created NAT gateway for which asynchronous asset synchronization has not yet completed.</para>
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
