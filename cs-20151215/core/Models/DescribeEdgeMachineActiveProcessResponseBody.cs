// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachineActiveProcessResponseBody : TeaModel {
        /// <summary>
        /// logs of activate
        /// </summary>
        [NameInMap("logs")]
        [Validation(Required=false)]
        public string Logs { get; set; }

        /// <summary>
        /// process of activate
        /// </summary>
        [NameInMap("progress")]
        [Validation(Required=false)]
        public long? Progress { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// state of activate
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// step of activate
        /// </summary>
        [NameInMap("step")]
        [Validation(Required=false)]
        public string Step { get; set; }

    }

}
