// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class PublishFlowVersionInput : TeaModel {
        /// <summary>
        /// <para>工作流版本的描述信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>Version 1.0 - Initial release</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
