// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListTenantAddonsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the plug-in.</para>
        /// </summary>
        [NameInMap("Addons")]
        [Validation(Required=false)]
        public List<ListTenantAddonsResponseBodyAddons> Addons { get; set; }
        public class ListTenantAddonsResponseBodyAddons : TeaModel {
            /// <summary>
            /// <para>The attributes of the plug-in.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public Dictionary<string, string> Attributes { get; set; }

            /// <summary>
            /// <para>The name of the plug-in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prometheus_discovery</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
