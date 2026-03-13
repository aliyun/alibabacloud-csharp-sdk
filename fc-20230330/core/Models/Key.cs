// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class Key : TeaModel {
        /// <summary>
        /// <para>The prefix that is used to filter the event-related resources. Only events related to the resources whose names are prefixed with the specified value of Prefix are traced. For example, if you set Prefix to serverless_, only events related to the resources that are prefixed with serverless_ can trigger the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>serverless_</para>
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The suffix that is used to filter the event-related resources. Only events related to the resources whose names are suffixed with the specified value of Suffix are traced. For example, if you set Suffix to .zip, only events related to the resources that are suffixed with .zip can trigger the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.zip</para>
        /// </summary>
        [NameInMap("suffix")]
        [Validation(Required=false)]
        public string Suffix { get; set; }

    }

}
