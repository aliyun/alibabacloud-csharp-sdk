// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListTagsForPrivateAccessApplicationResponseBody : TeaModel {
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListTagsForPrivateAccessApplicationResponseBodyApplications> Applications { get; set; }
        public class ListTagsForPrivateAccessApplicationResponseBodyApplications : TeaModel {
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTagsForPrivateAccessApplicationResponseBodyApplicationsTags> Tags { get; set; }
            public class ListTagsForPrivateAccessApplicationResponseBodyApplicationsTags : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                [NameInMap("TagType")]
                [Validation(Required=false)]
                public string TagType { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
