// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDrivesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Drives")]
        [Validation(Required=false)]
        public List<DescribeDrivesResponseBodyDrives> Drives { get; set; }
        public class DescribeDrivesResponseBodyDrives : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DesktopGroupCount")]
            [Validation(Required=false)]
            public int? DesktopGroupCount { get; set; }

            [NameInMap("DesktopGroups")]
            [Validation(Required=false)]
            public List<DescribeDrivesResponseBodyDrivesDesktopGroups> DesktopGroups { get; set; }
            public class DescribeDrivesResponseBodyDrivesDesktopGroups : TeaModel {
                [NameInMap("DesktopGroupId")]
                [Validation(Required=false)]
                public string DesktopGroupId { get; set; }

                [NameInMap("DesktopGroupName")]
                [Validation(Required=false)]
                public string DesktopGroupName { get; set; }

            }

            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            [NameInMap("DriveId")]
            [Validation(Required=false)]
            public string DriveId { get; set; }

            [NameInMap("EnableProfileManagement")]
            [Validation(Required=false)]
            public bool? EnableProfileManagement { get; set; }

            [NameInMap("ExternalDomainId")]
            [Validation(Required=false)]
            public string ExternalDomainId { get; set; }

            [NameInMap("ExternalDriveId")]
            [Validation(Required=false)]
            public string ExternalDriveId { get; set; }

            [NameInMap("ExternalUserId")]
            [Validation(Required=false)]
            public string ExternalUserId { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ProfileRoaming")]
            [Validation(Required=false)]
            public bool? ProfileRoaming { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UsedSize")]
            [Validation(Required=false)]
            public long? UsedSize { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
