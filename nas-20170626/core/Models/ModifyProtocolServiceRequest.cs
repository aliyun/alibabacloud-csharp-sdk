// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyProtocolServiceRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.
        /// 
        /// The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How do I ensure the idempotence?](https://help.aliyun.com/document_detail/25693.html)
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the request ID as the client token. The request ID may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the protocol service.
        /// 
        /// Limits:
        /// 
        /// *   The description must be 2 to 128 characters in length.
        /// *   The description must start with a letter and cannot start with `http://` or `https://`.
        /// *   The description can contain letters, digits, colons (:), underscores (_), and hyphens (-).
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. The dry run checks parameter validity and prerequisites. The dry run does not modify a file system or incur fees.
        /// 
        /// Valid values:
        /// 
        /// *   true: performs only a dry run and does not modify the protocol service. The system checks the request format, service limits, prerequisites, and whether the required parameters are specified. If the request fails the dry run, an error message is returned. If the request passes the dry run, a 200 HTTP status code is returned.
        /// *   false (default): performs a dry run and performs the actual request. If the request passes the dry run, the service protocol is modified.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the file system.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The ID of the protocol service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProtocolServiceId")]
        [Validation(Required=false)]
        public string ProtocolServiceId { get; set; }

    }

}
