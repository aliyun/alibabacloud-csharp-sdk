// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateTemplateRequest : TeaModel {
        /// <summary>
        /// <para>创建模板所需的完整配置信息，包括模板名称、类型、资源规格、网络配置等</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public CreateTemplateInput Body { get; set; }

    }

}
