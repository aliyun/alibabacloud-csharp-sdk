// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class DeleteNacosMcpServerRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mse_prepaid_public_cn-u0t2xzvxa06</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5e3c5211-d365-4013-8540-c4106ec2a5dc</para>
        /// </summary>
        [NameInMap("McpServerId")]
        [Validation(Required=false)]
        public string McpServerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fc0f6e40-****-946b-45e3af313707</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

    }

}
