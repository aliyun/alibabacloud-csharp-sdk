// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketDomain : TeaModel {
        /// <summary>
        /// <para>The custom domain name. This must be a valid DNS hostname.</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The network type of the endpoint. For example, <c>VPC</c> for an internal network or <c>INTERNET</c> for a public network.</para>
        /// </summary>
        [NameInMap("networkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The port number for the endpoint. For example, <c>80</c> for HTTP or <c>443</c> for HTTPS.</para>
        /// </summary>
        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>The communication protocol. Valid values include <c>HTTP</c> and <c>HTTPS</c>.</para>
        /// </summary>
        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

    }

}
