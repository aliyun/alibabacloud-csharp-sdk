// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class OpenAckServiceRequest : TeaModel {
        /// <summary>
        /// The type of service that you want to activate. Valid values:
        /// 
        /// *   `propayasgo`: ACK clusters (including ACK managed clusters and ACK dedicated clusters), ACK Serverless clusters, and registered clusters.
        /// *   `edgepayasgo`: ACK Edge clusters.
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
