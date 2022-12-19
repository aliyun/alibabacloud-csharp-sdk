// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUserBackupMachinesResponseBody : TeaModel {
        /// <summary>
        /// An array consisting of the servers to which the anti-ransomware policy is applied.
        /// </summary>
        [NameInMap("Machines")]
        [Validation(Required=false)]
        public List<DescribeUserBackupMachinesResponseBodyMachines> Machines { get; set; }
        public class DescribeUserBackupMachinesResponseBodyMachines : TeaModel {
            /// <summary>
            /// The ID of the anti-ransomware policy that is applied to the server.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// The name of the anti-ransomware policy that is applied to the server.
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// The UUID of the server to which the anti-ransomware policy is applied.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
