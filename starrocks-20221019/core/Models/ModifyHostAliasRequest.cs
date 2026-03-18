// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class ModifyHostAliasRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("hostAliases")]
        [Validation(Required=false)]
        public List<ModifyHostAliasRequestHostAliases> HostAliases { get; set; }
        public class ModifyHostAliasRequestHostAliases : TeaModel {
            [NameInMap("hostnames")]
            [Validation(Required=false)]
            public List<string> Hostnames { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>26.15.54.221</para>
            /// </summary>
            [NameInMap("ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

    }

}
