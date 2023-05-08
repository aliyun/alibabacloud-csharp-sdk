// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateAgentClientInstallResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the returned results.
        /// </summary>
        [NameInMap("AegisCelintInstallResposeList")]
        [Validation(Required=false)]
        public List<OperateAgentClientInstallResponseBodyAegisCelintInstallResposeList> AegisCelintInstallResposeList { get; set; }
        public class OperateAgentClientInstallResponseBodyAegisCelintInstallResposeList : TeaModel {
            /// <summary>
            /// The ID of the server.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The ID of the installation task.
            /// </summary>
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public long? RecordId { get; set; }

            /// <summary>
            /// The UUID of the server.
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
