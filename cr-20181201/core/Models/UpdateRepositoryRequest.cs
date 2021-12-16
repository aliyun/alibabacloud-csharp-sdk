// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class UpdateRepositoryRequest : TeaModel {
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public string RepoId { get; set; }

        [NameInMap("RepoType")]
        [Validation(Required=false)]
        public string RepoType { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("TagImmutability")]
        [Validation(Required=false)]
        public bool? TagImmutability { get; set; }

    }

}
