// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ModifyBuildpackRequest : TeaModel {
        [NameInMap("AvailableTenantNamesRepeatList")]
        [Validation(Required=false)]
        public List<string> AvailableTenantNamesRepeatList { get; set; }

        [NameInMap("BuildpackId")]
        [Validation(Required=false)]
        public string BuildpackId { get; set; }

        [NameInMap("BuildpackParams")]
        [Validation(Required=false)]
        public List<ModifyBuildpackRequestBuildpackParams> BuildpackParams { get; set; }
        public class ModifyBuildpackRequestBuildpackParams : TeaModel {
            [NameInMap("BuildpackId")]
            [Validation(Required=false)]
            public string BuildpackId { get; set; }

            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Readonly")]
            [Validation(Required=false)]
            public bool? Readonly { get; set; }

            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

        }

        [NameInMap("ContactInfo")]
        [Validation(Required=false)]
        public string ContactInfo { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EnvParams")]
        [Validation(Required=false)]
        public List<ModifyBuildpackRequestEnvParams> EnvParams { get; set; }
        public class ModifyBuildpackRequestEnvParams : TeaModel {
            [NameInMap("BuildpackId")]
            [Validation(Required=false)]
            public string BuildpackId { get; set; }

            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Readonly")]
            [Validation(Required=false)]
            public bool? Readonly { get; set; }

            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

        }

        [NameInMap("FullVersion")]
        [Validation(Required=false)]
        public string FullVersion { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SupportedOsRepeatList")]
        [Validation(Required=false)]
        public List<long?> SupportedOsRepeatList { get; set; }

        [NameInMap("SupportedRegions")]
        [Validation(Required=false)]
        public List<ModifyBuildpackRequestSupportedRegions> SupportedRegions { get; set; }
        public class ModifyBuildpackRequestSupportedRegions : TeaModel {
            [NameInMap("BuildpackId")]
            [Validation(Required=false)]
            public string BuildpackId { get; set; }

            [NameInMap("BuildpackTenantId")]
            [Validation(Required=false)]
            public string BuildpackTenantId { get; set; }

            [NameInMap("FileChecksum")]
            [Validation(Required=false)]
            public string FileChecksum { get; set; }

            [NameInMap("FileLocation")]
            [Validation(Required=false)]
            public string FileLocation { get; set; }

            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

            [NameInMap("FileStatus")]
            [Validation(Required=false)]
            public string FileStatus { get; set; }

            [NameInMap("FromRegionId")]
            [Validation(Required=false)]
            public string FromRegionId { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("ObjectName")]
            [Validation(Required=false)]
            public string ObjectName { get; set; }

            [NameInMap("OriginalFileName")]
            [Validation(Required=false)]
            public string OriginalFileName { get; set; }

            [NameInMap("ReadableFileSize")]
            [Validation(Required=false)]
            public string ReadableFileSize { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RegionIdentity")]
            [Validation(Required=false)]
            public string RegionIdentity { get; set; }

            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        [NameInMap("TechstackId")]
        [Validation(Required=false)]
        public string TechstackId { get; set; }

    }

}
