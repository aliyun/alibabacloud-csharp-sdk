// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListMetaCollectionsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the collection administrator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1200759642363000</para>
        /// </summary>
        [NameInMap("Administrator")]
        [Validation(Required=false)]
        public string Administrator { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>ALBUM: data album </description></item>
        /// <item><description>ALBUM_CATEGORY: category in a data album</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALBUM</para>
        /// </summary>
        [NameInMap("CollectionType")]
        [Validation(Required=false)]
        public string CollectionType { get; set; }

        /// <summary>
        /// <para>The ID of the collection creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1200759642363000</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The ID of the collection follower.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1200759642363000</para>
        /// </summary>
        [NameInMap("Follower")]
        [Validation(Required=false)]
        public string Follower { get; set; }

        /// <summary>
        /// <para>The keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The name of the sorting field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique identifier of the parent collection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Album.1234</para>
        /// </summary>
        [NameInMap("ParentQualifiedName")]
        [Validation(Required=false)]
        public string ParentQualifiedName { get; set; }

    }

}
