// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Catalog : TeaModel {
        [NameInMap("extensionConf")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtensionConf { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("properties")]
        [Validation(Required=false)]
        public Dictionary<string, object> Properties { get; set; }

    }

}
