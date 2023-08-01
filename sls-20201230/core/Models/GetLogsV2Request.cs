// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetLogsV2Request : TeaModel {
        [NameInMap("forward")]
        [Validation(Required=false)]
        public bool? Forward { get; set; }

        [NameInMap("from")]
        [Validation(Required=false)]
        public int? From { get; set; }

        [NameInMap("line")]
        [Validation(Required=false)]
        public long? Line { get; set; }

        [NameInMap("offset")]
        [Validation(Required=false)]
        public long? Offset { get; set; }

        [NameInMap("powerSql")]
        [Validation(Required=false)]
        public bool? PowerSql { get; set; }

        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

        [NameInMap("session")]
        [Validation(Required=false)]
        public string Session { get; set; }

        /// <summary>
        /// Shard ID。
        /// </summary>
        [NameInMap("shard")]
        [Validation(Required=false)]
        public int? Shard { get; set; }

        [NameInMap("to")]
        [Validation(Required=false)]
        public int? To { get; set; }

        [NameInMap("topic")]
        [Validation(Required=false)]
        public string Topic { get; set; }

    }

}
