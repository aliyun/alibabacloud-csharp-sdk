// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetCustomAgentRequest : TeaModel {
        /// <summary>
        /// <para>The operation that you want to perform. Set the value to <b>GetCustomAgent</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ebe44453-3b41-4c74-94d1-01d088d7xxxx</para>
        /// </summary>
        [NameInMap("CustomAgentId")]
        [Validation(Required=false)]
        public string CustomAgentId { get; set; }

    }

}
