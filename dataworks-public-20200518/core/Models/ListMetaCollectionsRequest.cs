// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListMetaCollectionsRequest : TeaModel {
        /// <summary>
        /// The ID of the collection administrator.
        /// </summary>
        [NameInMap("Administrator")]
        [Validation(Required=false)]
        public string Administrator { get; set; }

        /// <summary>
        /// - ALBUM: data album 
        /// - ALBUM_CATEGORY: category in a data album
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CollectionType")]
        [Validation(Required=false)]
        public string CollectionType { get; set; }

        /// <summary>
        /// The ID of the collection creator.
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// The ID of the collection follower.
        /// </summary>
        [NameInMap("Follower")]
        [Validation(Required=false)]
        public string Follower { get; set; }

        /// <summary>
        /// The keyword.
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The name of the sorting field.
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 10. Maximum value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The unique identifier of the parent collection.
        /// </summary>
        [NameInMap("ParentQualifiedName")]
        [Validation(Required=false)]
        public string ParentQualifiedName { get; set; }

    }

}
