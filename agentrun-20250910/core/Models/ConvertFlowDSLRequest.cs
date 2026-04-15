// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ConvertFlowDSLRequest : TeaModel {
        /// <summary>
        /// <para>包含待转换的工作流DSL内容和转换选项，支持多种DSL格式（如Dify、n8n等）以及inline和base64两种输入方式</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public ConvertFlowDSLInput Body { get; set; }

    }

}
