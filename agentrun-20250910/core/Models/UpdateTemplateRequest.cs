// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateTemplateRequest : TeaModel {
        /// <summary>
        /// <para>更新模板所需的配置信息</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateTemplateInput Body { get; set; }

        /// <summary>
        /// <para>用于确保请求幂等性的唯一标识符</para>
        /// 
        /// <b>Example:</b>
        /// <para>clientToken</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
