// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class ModifyHostAliasRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Host alias list.</para>
        /// </summary>
        [NameInMap("hostAliases")]
        [Validation(Required=false)]
        public List<ModifyHostAliasRequestHostAliases> HostAliases { get; set; }
        public class ModifyHostAliasRequestHostAliases : TeaModel {
            /// <summary>
            /// <para>Host alias.</para>
            /// </summary>
            [NameInMap("hostnames")]
            [Validation(Required=false)]
            public List<string> Hostnames { get; set; }

            /// <summary>
            /// <para>Machine IP</para>
            /// 
            /// <b>Example:</b>
            /// <para>26.15.54.221</para>
            /// </summary>
            [NameInMap("ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

    }

}
