// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListMetaCollectionsRequest : TeaModel {
        [NameInMap("Administrator")]
        [Validation(Required=false)]
        public string Administrator { get; set; }

        [NameInMap("CollectionType")]
        [Validation(Required=false)]
        public string CollectionType { get; set; }

        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("Follower")]
        [Validation(Required=false)]
        public string Follower { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ParentQualifiedName")]
        [Validation(Required=false)]
        public string ParentQualifiedName { get; set; }

    }

}
