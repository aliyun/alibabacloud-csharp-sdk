// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateRepositoryMemberRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("accessLevel")]
        [Validation(Required=false)]
        public int? AccessLevel { get; set; }

        [NameInMap("expireAt")]
        [Validation(Required=false)]
        public string ExpireAt { get; set; }

        [NameInMap("memberType")]
        [Validation(Required=false)]
        public string MemberType { get; set; }

        [NameInMap("relatedId")]
        [Validation(Required=false)]
        public string RelatedId { get; set; }

        [NameInMap("relatedInfos")]
        [Validation(Required=false)]
        public List<UpdateRepositoryMemberRequestRelatedInfos> RelatedInfos { get; set; }
        public class UpdateRepositoryMemberRequestRelatedInfos : TeaModel {
            [NameInMap("relatedId")]
            [Validation(Required=false)]
            public string RelatedId { get; set; }

            [NameInMap("sourceId")]
            [Validation(Required=false)]
            public long? SourceId { get; set; }

            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
