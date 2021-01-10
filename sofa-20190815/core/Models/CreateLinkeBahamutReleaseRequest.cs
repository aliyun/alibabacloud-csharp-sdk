// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLinkeBahamutReleaseRequest : TeaModel {
        [NameInMap("AoneReleaseId")]
        [Validation(Required=false)]
        public string AoneReleaseId { get; set; }

        [NameInMap("AppGroup")]
        [Validation(Required=false)]
        public string AppGroup { get; set; }

        [NameInMap("MergeDeadline")]
        [Validation(Required=false)]
        public long? MergeDeadline { get; set; }

        [NameInMap("MergeStartTime")]
        [Validation(Required=false)]
        public long? MergeStartTime { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PrePubDeadline")]
        [Validation(Required=false)]
        public long? PrePubDeadline { get; set; }

        [NameInMap("ReleaseDate")]
        [Validation(Required=false)]
        public long? ReleaseDate { get; set; }

        [NameInMap("SubmitDeadline")]
        [Validation(Required=false)]
        public long? SubmitDeadline { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("ManagersRepeatList")]
        [Validation(Required=false)]
        public List<string> ManagersRepeatList { get; set; }

    }

}
