// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Teambition_aliyun20200226.Models
{
    public class GetProjectInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("Object")]
        [Validation(Required=false)]
        public GetProjectInfoResponseBodyObject Object { get; set; }
        public class GetProjectInfoResponseBodyObject : TeaModel {
            [NameInMap("SortMethod")]
            [Validation(Required=false)]
            public string SortMethod { get; set; }
            [NameInMap("UniqueIdPrefix")]
            [Validation(Required=false)]
            public string UniqueIdPrefix { get; set; }
            [NameInMap("NormalType")]
            [Validation(Required=false)]
            public string NormalType { get; set; }
            [NameInMap("ModifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }
            [NameInMap("IsTemplate")]
            [Validation(Required=false)]
            public bool? IsTemplate { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("DefaultRoleId")]
            [Validation(Required=false)]
            public string DefaultRoleId { get; set; }
            [NameInMap("RootCollectionId")]
            [Validation(Required=false)]
            public string RootCollectionId { get; set; }
            [NameInMap("IsDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }
            [NameInMap("Updated")]
            [Validation(Required=false)]
            public string Updated { get; set; }
            [NameInMap("IsArchived")]
            [Validation(Required=false)]
            public bool? IsArchived { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }
            [NameInMap("Logo")]
            [Validation(Required=false)]
            public string Logo { get; set; }
            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }
            [NameInMap("Pinyin")]
            [Validation(Required=false)]
            public string Pinyin { get; set; }
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }
            [NameInMap("IsSuspended")]
            [Validation(Required=false)]
            public bool? IsSuspended { get; set; }
            [NameInMap("DefaultCollectionId")]
            [Validation(Required=false)]
            public string DefaultCollectionId { get; set; }
            [NameInMap("Visibility")]
            [Validation(Required=false)]
            public string Visibility { get; set; }
            [NameInMap("Py")]
            [Validation(Required=false)]
            public string Py { get; set; }
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }
            [NameInMap("NextTaskUniqueId")]
            [Validation(Required=false)]
            public int? NextTaskUniqueId { get; set; }
            [NameInMap("Customfields")]
            [Validation(Required=false)]
            public string Customfields { get; set; }
            [NameInMap("Created")]
            [Validation(Required=false)]
            public string Created { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Successful")]
        [Validation(Required=false)]
        public bool? Successful { get; set; }

    }

}
