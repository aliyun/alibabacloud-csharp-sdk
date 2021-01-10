// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateBuildpackRequest : TeaModel {
        [NameInMap("BuildCommand")]
        [Validation(Required=false)]
        public string BuildCommand { get; set; }

        [NameInMap("ContactInfo")]
        [Validation(Required=false)]
        public string ContactInfo { get; set; }

        [NameInMap("DebugMode")]
        [Validation(Required=false)]
        public bool? DebugMode { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FullVersion")]
        [Validation(Required=false)]
        public string FullVersion { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("MajorVersion")]
        [Validation(Required=false)]
        public long? MajorVersion { get; set; }

        [NameInMap("MinorVersion")]
        [Validation(Required=false)]
        public long? MinorVersion { get; set; }

        [NameInMap("PatchVersion")]
        [Validation(Required=false)]
        public long? PatchVersion { get; set; }

        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StorageUploadEndpoints")]
        [Validation(Required=false)]
        public string StorageUploadEndpoints { get; set; }

        [NameInMap("TechstackJsonStr")]
        [Validation(Required=false)]
        public string TechstackJsonStr { get; set; }

        [NameInMap("TechstackId")]
        [Validation(Required=false)]
        public long? TechstackId { get; set; }

        [NameInMap("AvailableTenantNamesRepeatList")]
        [Validation(Required=false)]
        public List<string> AvailableTenantNamesRepeatList { get; set; }

        [NameInMap("BuildpackParams")]
        [Validation(Required=false)]
        public List<CreateBuildpackRequestBuildpackParams> BuildpackParams { get; set; }
        public class CreateBuildpackRequestBuildpackParams : TeaModel {
            [NameInMap("BuildpackId")]
            [Validation(Required=false)]
            public string BuildpackId { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            [NameInMap("Readonly")]
            [Validation(Required=false)]
            public bool? Readonly { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        [NameInMap("BuildCommandParams")]
        [Validation(Required=false)]
        public List<CreateBuildpackRequestBuildCommandParams> BuildCommandParams { get; set; }
        public class CreateBuildpackRequestBuildCommandParams : TeaModel {
            [NameInMap("BuildpackId")]
            [Validation(Required=false)]
            public string BuildpackId { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

        }

        [NameInMap("SupportedOsRepeatList")]
        [Validation(Required=false)]
        public List<int?> SupportedOsRepeatList { get; set; }

        [NameInMap("SupportedRegions")]
        [Validation(Required=false)]
        public List<CreateBuildpackRequestSupportedRegions> SupportedRegions { get; set; }
        public class CreateBuildpackRequestSupportedRegions : TeaModel {
            [NameInMap("FileChecksum")]
            [Validation(Required=false)]
            public string FileChecksum { get; set; }

            [NameInMap("BuildpackTenantId")]
            [Validation(Required=false)]
            public string BuildpackTenantId { get; set; }

            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            [NameInMap("ObjectName")]
            [Validation(Required=false)]
            public string ObjectName { get; set; }

            [NameInMap("OriginalFileName")]
            [Validation(Required=false)]
            public string OriginalFileName { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("BuildpackId")]
            [Validation(Required=false)]
            public string BuildpackId { get; set; }

            [NameInMap("FromRegionId")]
            [Validation(Required=false)]
            public string FromRegionId { get; set; }

            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            [NameInMap("FileLocation")]
            [Validation(Required=false)]
            public string FileLocation { get; set; }

            [NameInMap("ReadableFileSize")]
            [Validation(Required=false)]
            public string ReadableFileSize { get; set; }

            [NameInMap("FileStatus")]
            [Validation(Required=false)]
            public string FileStatus { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("RegionIdentity")]
            [Validation(Required=false)]
            public string RegionIdentity { get; set; }

            [NameInMap("FileSize")]
            [Validation(Required=false)]
            public long? FileSize { get; set; }

        }

    }

}
