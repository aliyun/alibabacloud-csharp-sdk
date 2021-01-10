// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryAKSBuildPackTechStackVersionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<QueryAKSBuildPackTechStackVersionsResponseBodyList> List { get; set; }
        public class QueryAKSBuildPackTechStackVersionsResponseBodyList : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ExternalDestImage")]
            [Validation(Required=false)]
            public string ExternalDestImage { get; set; }

            [NameInMap("ExternalRegistryPassword")]
            [Validation(Required=false)]
            public string ExternalRegistryPassword { get; set; }

            [NameInMap("ExternalRegistryUser")]
            [Validation(Required=false)]
            public string ExternalRegistryUser { get; set; }

            [NameInMap("FromImage")]
            [Validation(Required=false)]
            public string FromImage { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Online")]
            [Validation(Required=false)]
            public bool? Online { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("PackageDir")]
            [Validation(Required=false)]
            public string PackageDir { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RegistryPassword")]
            [Validation(Required=false)]
            public string RegistryPassword { get; set; }

            [NameInMap("RegistryUser")]
            [Validation(Required=false)]
            public string RegistryUser { get; set; }

            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            [NameInMap("TechStack")]
            [Validation(Required=false)]
            public string TechStack { get; set; }

            [NameInMap("TechStackId")]
            [Validation(Required=false)]
            public string TechStackId { get; set; }

            [NameInMap("UtcCreated")]
            [Validation(Required=false)]
            public string UtcCreated { get; set; }

            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
