// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SearchEditingProjectResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("ProjectList")]
        [Validation(Required=false)]
        public SearchEditingProjectResponseBodyProjectList ProjectList { get; set; }
        public class SearchEditingProjectResponseBodyProjectList : TeaModel {
            [NameInMap("Project")]
            [Validation(Required=false)]
            public List<SearchEditingProjectResponseBodyProjectListProject> Project { get; set; }
            public class SearchEditingProjectResponseBodyProjectListProject : TeaModel {
                public string StorageLocation { get; set; }
                public string Status { get; set; }
                public string CreationTime { get; set; }
                public string ModifiedTime { get; set; }
                public string Description { get; set; }
                public string CoverURL { get; set; }
                public string ProjectId { get; set; }
                public float? Duration { get; set; }
                public string Title { get; set; }
                public string RegionId { get; set; }
            }
        };

    }

}
