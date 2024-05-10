// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeSslVpnClientCertResponseBody : TeaModel {
        /// <summary>
        /// The CA certificate.
        /// </summary>
        [NameInMap("CaCert")]
        [Validation(Required=false)]
        public string CaCert { get; set; }

        /// <summary>
        /// The client certificate.
        /// </summary>
        [NameInMap("ClientCert")]
        [Validation(Required=false)]
        public string ClientCert { get; set; }

        /// <summary>
        /// The client configuration.
        /// </summary>
        [NameInMap("ClientConfig")]
        [Validation(Required=false)]
        public string ClientConfig { get; set; }

        /// <summary>
        /// The client key.
        /// </summary>
        [NameInMap("ClientKey")]
        [Validation(Required=false)]
        public string ClientKey { get; set; }

        /// <summary>
        /// The timestamp that indicates when the SSL client certificate was created. Unit: milliseconds.
        /// 
        /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// The timestamp that indicates when the SSL client certificate expires. Unit: milliseconds.
        /// 
        /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The name of the SSL client certificate.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the region where the SSL client certificate is created.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the SSL client certificate belongs.
        /// 
        /// The SSL client certificate is the same as the resource group of the SSL server associated with it.
        /// 
        /// You can call the [ListResourceGroups](https://help.aliyun.com/document_detail/158855.html) operation to query the resource group information.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the SSL client certificate.
        /// </summary>
        [NameInMap("SslVpnClientCertId")]
        [Validation(Required=false)]
        public string SslVpnClientCertId { get; set; }

        /// <summary>
        /// The ID of the SSL server.
        /// </summary>
        [NameInMap("SslVpnServerId")]
        [Validation(Required=false)]
        public string SslVpnServerId { get; set; }

        /// <summary>
        /// The status of the SSL client certificate. Valid values:
        /// 
        /// *   **expiring-soon**
        /// *   **normal**
        /// *   **expired**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
