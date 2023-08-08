// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachineActiveProcessResponseBody : TeaModel {
        /// <summary>
        /// The list of details about the activation progress.
        /// </summary>
        [NameInMap("logs")]
        [Validation(Required=false)]
        public string Logs { get; set; }

        /// <summary>
        /// The activation progress.
        /// </summary>
        [NameInMap("progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the cloud-native box.
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The current step of the activation process.
        /// </summary>
        [NameInMap("step")]
        [Validation(Required=false)]
        public string Step { get; set; }

    }

}
