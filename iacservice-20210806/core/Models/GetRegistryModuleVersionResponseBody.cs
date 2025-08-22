// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetRegistryModuleVersionResponseBody : TeaModel {
        [NameInMap("moduleVersion")]
        [Validation(Required=false)]
        public GetRegistryModuleVersionResponseBodyModuleVersion ModuleVersion { get; set; }
        public class GetRegistryModuleVersionResponseBodyModuleVersion : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("detailUrl")]
            [Validation(Required=false)]
            public string DetailUrl { get; set; }

            [NameInMap("downloads")]
            [Validation(Required=false)]
            public string Downloads { get; set; }

            [NameInMap("moduleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            [NameInMap("namespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("sourceUrl")]
            [Validation(Required=false)]
            public string SourceUrl { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>62DF26B0-53F0-5747-9D7F-FEF444FB4E24</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
