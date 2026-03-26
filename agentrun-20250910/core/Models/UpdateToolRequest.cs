// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateToolRequest : TeaModel {
        /// <summary>
        /// <para>更新工具的请求参数，只需提供需要修改的字段</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateToolInputV2 Body { get; set; }

    }

}
