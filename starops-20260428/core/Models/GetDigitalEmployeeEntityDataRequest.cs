// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class GetDigitalEmployeeEntityDataRequest : TeaModel {
        /// <summary>
        /// <para>The UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1770000000</para>
        /// </summary>
        [NameInMap("from")]
        [Validation(Required=false)]
        public long? From { get; set; }

        /// <summary>
        /// <para>Only the .entity or .topo semantic sources of the current digital employee can be queried. Explicit access to internal storage or external data sources is prohibited.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.entity with(type=\&quot;deployment\&quot;, domain=\&quot;k8s\&quot;) | limit 100</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp. Unit: seconds. The value must be greater than the value of from.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1770003600</para>
        /// </summary>
        [NameInMap("to")]
        [Validation(Required=false)]
        public long? To { get; set; }

    }

}
