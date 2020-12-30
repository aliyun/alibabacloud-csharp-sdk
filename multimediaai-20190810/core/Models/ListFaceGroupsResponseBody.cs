// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Multimediaai20190810.Models
{
    public class ListFaceGroupsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("FaceGroups")]
        [Validation(Required=false)]
        public List<ListFaceGroupsResponseBodyFaceGroups> FaceGroups { get; set; }
        public class ListFaceGroupsResponseBodyFaceGroups : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("FaceGroupName")]
            [Validation(Required=false)]
            public string FaceGroupName { get; set; }

            [NameInMap("PersonCount")]
            [Validation(Required=false)]
            public long? PersonCount { get; set; }

            [NameInMap("ImageCount")]
            [Validation(Required=false)]
            public long? ImageCount { get; set; }

            [NameInMap("FaceGroupId")]
            [Validation(Required=false)]
            public long? FaceGroupId { get; set; }

            [NameInMap("Templates")]
            [Validation(Required=false)]
            public List<ListFaceGroupsResponseBodyFaceGroupsTemplates> Templates { get; set; }
            public class ListFaceGroupsResponseBodyFaceGroupsTemplates : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

        }

    }

}
