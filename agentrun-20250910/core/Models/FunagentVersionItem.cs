// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class FunagentVersionItem : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>多条更新说明</para>
        /// </summary>
        [NameInMap("publishContent")]
        [Validation(Required=false)]
        public List<string> PublishContent { get; set; }

        /// <summary>
        /// <para>日期或 ISO 8601 字符串</para>
        /// </summary>
        [NameInMap("publishTime")]
        [Validation(Required=false)]
        public string PublishTime { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
