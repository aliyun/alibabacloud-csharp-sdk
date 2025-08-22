// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetRegistryModuleResponseBody : TeaModel {
        [NameInMap("registryModule")]
        [Validation(Required=false)]
        public GetRegistryModuleResponseBodyRegistryModule RegistryModule { get; set; }
        public class GetRegistryModuleResponseBodyRegistryModule : TeaModel {
            [NameInMap("acl")]
            [Validation(Required=false)]
            public string Acl { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("downloads")]
            [Validation(Required=false)]
            public int? Downloads { get; set; }

            [NameInMap("moduleName")]
            [Validation(Required=false)]
            public string ModuleName { get; set; }

            [NameInMap("namespaceName")]
            [Validation(Required=false)]
            public string NamespaceName { get; set; }

            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            [NameInMap("sharedAccounts")]
            [Validation(Required=false)]
            public List<long?> SharedAccounts { get; set; }

            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("sourceUrl")]
            [Validation(Required=false)]
            public string SourceUrl { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5B5AD471-5036-581B-AC9B-7D5EECED877A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
