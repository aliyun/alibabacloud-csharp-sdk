// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class SearchMemoryRequest : TeaModel {
        [NameInMap("agent_id")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        [NameInMap("enhancements")]
        [Validation(Required=false)]
        public Dictionary<string, object> Enhancements { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("run_id")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
