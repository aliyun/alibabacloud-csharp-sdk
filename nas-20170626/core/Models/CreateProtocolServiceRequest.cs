// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateProtocolServiceRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.
        /// 
        /// The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How do I ensure the idempotence?](~~25693~~)
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the request ID as the client token. The request ID may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the protocol service. The name of the protocol service appears in the console.
        /// 
        /// Limits:
        /// 
        /// *   The description must be 2 to 128 characters in length.
        /// *   The description must start with a letter and cannot start with `http://` or `https://`.
        /// *   The description can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run.
        /// 
        /// The dry run checks parameter validity and prerequisites. The dry run does not create a protocol service or incur fees.
        /// 
        /// Valid values:
        /// 
        /// *   true: performs only a dry run and does not create the protocol service. The system checks the request format, service limits, prerequisites, and whether the required parameters are specified. If the request fails the dry run, an error message is returned. If the request passes the dry run, the HTTP status code 200 is returned. No value is returned for the ProtocolServiceId parameter.
        /// *   false (default): performs a dry run and sends the request. If the request passes the dry run, a protocol service is created.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The ID of the file system.
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// The specification of the protocol service.
        /// 
        /// Set the value to General (default).
        /// 
        /// Valid values:
        /// 
        /// *   CL2
        /// *   General
        /// *   CL1
        /// </summary>
        [NameInMap("ProtocolSpec")]
        [Validation(Required=false)]
        public string ProtocolSpec { get; set; }

        /// <summary>
        /// The protocol type of the protocol service.
        /// 
        /// Valid value: NFS (default). Only NFSv3 is supported.
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// The throughput of the protocol service.
        /// 
        /// Unit: MB/s.
        /// </summary>
        [NameInMap("Throughput")]
        [Validation(Required=false)]
        public int? Throughput { get; set; }

        /// <summary>
        /// The vSwitch ID of the protocol service.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The virtual private cloud (VPC) ID of the protocol service. The VPC ID of the protocol service must be the same as the VPC ID of the file system.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
