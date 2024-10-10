// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class GetInstanceLogsInput : TeaModel {
        [NameInMap("backwardLine")]
        [Validation(Required=false)]
        public long? BackwardLine { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("forwardLine")]
        [Validation(Required=false)]
        public long? ForwardLine { get; set; }

        [NameInMap("isTail")]
        [Validation(Required=false)]
        public bool? IsTail { get; set; }

        [NameInMap("match")]
        [Validation(Required=false)]
        public string Match { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        [NameInMap("packID")]
        [Validation(Required=false)]
        public string PackID { get; set; }

        [NameInMap("packMeta")]
        [Validation(Required=false)]
        public string PackMeta { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

        [NameInMap("versionID")]
        [Validation(Required=false)]
        public string VersionID { get; set; }

    }

}
