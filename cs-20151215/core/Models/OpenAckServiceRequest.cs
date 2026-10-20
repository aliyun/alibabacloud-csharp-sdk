// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class OpenAckServiceRequest : TeaModel {
        /// <summary>
        /// <para>The type of service to activate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>propayasgo</c>: Container Service for Kubernetes (including ACK managed clusters and ACK dedicated clusters), Container Service Serverless, and registered clusters.</description></item>
        /// <item><description><c>edgepayasgo</c>: Container Service Edge.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>propayasgo</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
