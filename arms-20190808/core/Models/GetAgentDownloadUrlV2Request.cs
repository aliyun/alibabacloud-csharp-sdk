// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetAgentDownloadUrlV2Request : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        [NameInMap("ArchType")]
        [Validation(Required=false)]
        public string ArchType { get; set; }

        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

    }

}
