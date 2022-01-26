// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20190430.Models
{
    public class CreateProjectRequest : TeaModel {
        [NameInMap("AreaCode")]
        [Validation(Required=false)]
        public string AreaCode { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TimeZoneCode")]
        [Validation(Required=false)]
        public string TimeZoneCode { get; set; }

        [NameInMap("VcsId")]
        [Validation(Required=false)]
        public string VcsId { get; set; }

    }

}
