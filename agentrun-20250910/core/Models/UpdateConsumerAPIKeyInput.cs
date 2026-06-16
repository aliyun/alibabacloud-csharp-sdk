// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateConsumerAPIKeyInput : TeaModel {
        /// <summary>
        /// <para>Indicates if the key is active.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// <para>A new description for the key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>更新后的密钥描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
