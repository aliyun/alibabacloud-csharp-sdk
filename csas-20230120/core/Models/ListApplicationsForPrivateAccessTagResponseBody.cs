// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApplicationsForPrivateAccessTagResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListApplicationsForPrivateAccessTagResponseBodyTags> Tags { get; set; }
        public class ListApplicationsForPrivateAccessTagResponseBodyTags : TeaModel {
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListApplicationsForPrivateAccessTagResponseBodyTagsApplications> Applications { get; set; }
            public class ListApplicationsForPrivateAccessTagResponseBodyTagsApplications : TeaModel {
                [NameInMap("Addresses")]
                [Validation(Required=false)]
                public List<string> Addresses { get; set; }

                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                /// <summary>
                /// 内网访问应用创建时间。
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PortRanges")]
                [Validation(Required=false)]
                public List<ListApplicationsForPrivateAccessTagResponseBodyTagsApplicationsPortRanges> PortRanges { get; set; }
                public class ListApplicationsForPrivateAccessTagResponseBodyTagsApplicationsPortRanges : TeaModel {
                    [NameInMap("Begin")]
                    [Validation(Required=false)]
                    public int? Begin { get; set; }

                    [NameInMap("End")]
                    [Validation(Required=false)]
                    public int? End { get; set; }

                }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

        }

    }

}
