// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetInstanceADAuthServerResponseBody : TeaModel {
        /// <summary>
        /// The operation that you want to perform. Set the value to **GetInstanceADAuthServer**.
        /// </summary>
        [NameInMap("AD")]
        [Validation(Required=false)]
        public GetInstanceADAuthServerResponseBodyAD AD { get; set; }
        public class GetInstanceADAuthServerResponseBodyAD : TeaModel {
            /// <summary>
            /// The port that is used to access the AD server.
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// The ID of the bastion host to query.
            /// 
            /// You can call the [DescribeInstances](~~153281~~) operation to query the ID of the bastion host.
            /// </summary>
            [NameInMap("BaseDN")]
            [Validation(Required=false)]
            public string BaseDN { get; set; }

            /// <summary>
            /// The settings of AD authentication.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The address of the secondary AD server.
            /// </summary>
            [NameInMap("EmailMapping")]
            [Validation(Required=false)]
            public string EmailMapping { get; set; }

            /// <summary>
            /// The field that is used to indicate the mobile phone number of a user on the AD server.
            /// </summary>
            [NameInMap("Filter")]
            [Validation(Required=false)]
            public string Filter { get; set; }

            /// <summary>
            /// The address of the AD server.
            /// </summary>
            [NameInMap("HasPassword")]
            [Validation(Required=false)]
            public bool? HasPassword { get; set; }

            /// <summary>
            /// The Base DN of the AD server.
            /// </summary>
            [NameInMap("IsSSL")]
            [Validation(Required=false)]
            public bool? IsSSL { get; set; }

            /// <summary>
            /// The field that is used to indicate the name of a user on the AD server.
            /// </summary>
            [NameInMap("MobileMapping")]
            [Validation(Required=false)]
            public string MobileMapping { get; set; }

            /// <summary>
            /// The ID of the request, which is used to locate and troubleshoot issues.
            /// </summary>
            [NameInMap("NameMapping")]
            [Validation(Required=false)]
            public string NameMapping { get; set; }

            /// <summary>
            /// Queries the settings of Active Directory (AD) authentication on a bastion host.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public long? Port { get; set; }

            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            [NameInMap("StandbyServer")]
            [Validation(Required=false)]
            public string StandbyServer { get; set; }

        }

        /// <summary>
        /// Indicates whether SSL is supported. Valid values:
        /// 
        /// *   **true**: supported
        /// *   **false**: not supported
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
