// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class GetGlobalAppResponseBody : TeaModel {
        [NameInMap("AppDefaultVersion")]
        [Validation(Required=false)]
        public string AppDefaultVersion { get; set; }

        [NameInMap("AppDescription")]
        [Validation(Required=false)]
        public string AppDescription { get; set; }

        [NameInMap("AppDescriptorFiles")]
        [Validation(Required=false)]
        public List<GetGlobalAppResponseBodyAppDescriptorFiles> AppDescriptorFiles { get; set; }
        public class GetGlobalAppResponseBodyAppDescriptorFiles : TeaModel {
            [NameInMap("Checksum")]
            [Validation(Required=false)]
            public string Checksum { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("FileType")]
            [Validation(Required=false)]
            public string FileType { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("AppDescriptorType")]
        [Validation(Required=false)]
        public string AppDescriptorType { get; set; }

        [NameInMap("AppFee")]
        [Validation(Required=false)]
        public string AppFee { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AppScope")]
        [Validation(Required=false)]
        public string AppScope { get; set; }

        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("AppVersions")]
        [Validation(Required=false)]
        public List<GetGlobalAppResponseBodyAppVersions> AppVersions { get; set; }
        public class GetGlobalAppResponseBodyAppVersions : TeaModel {
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

        }

        [NameInMap("Categories")]
        [Validation(Required=false)]
        public List<string> Categories { get; set; }

        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("Contact")]
        [Validation(Required=false)]
        public string Contact { get; set; }

        [NameInMap("DAG")]
        [Validation(Required=false)]
        public string DAG { get; set; }

        [NameInMap("Document")]
        [Validation(Required=false)]
        public string Document { get; set; }

        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        [NameInMap("LastModified")]
        [Validation(Required=false)]
        public string LastModified { get; set; }

        [NameInMap("Links")]
        [Validation(Required=false)]
        public List<string> Links { get; set; }

        [NameInMap("Locations")]
        [Validation(Required=false)]
        public List<string> Locations { get; set; }

        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        [NameInMap("Pinned")]
        [Validation(Required=false)]
        public bool? Pinned { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Toolkit")]
        [Validation(Required=false)]
        public string Toolkit { get; set; }

    }

}
