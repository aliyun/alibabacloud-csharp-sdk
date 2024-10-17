// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class NodeGroupStateChangeReason : TeaModel {
        /// <summary>
        /// <para>状态码。</para>
        /// 
        /// <b>Example:</b>
        /// <para>MissingParameter</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>描述信息。</para>
        /// 
        /// <b>Example:</b>
        /// <para>The instance type is required.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
