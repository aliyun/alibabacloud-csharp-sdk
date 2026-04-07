// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class Collection : TeaModel {
        /// <summary>
        /// <para>The type of the collection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALBUM</b>: data album</description></item>
        /// <item><description><b>ALBUM_CATEGORY</b>: category in a data album</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>album</para>
        /// </summary>
        [NameInMap("CollectionType")]
        [Validation(Required=false)]
        public string CollectionType { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>comment</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1668600147617</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The level of the collection. This parameter takes effect only if the CollectionType parameter is set to ALBUM_CATEGORY. Maximum value: 4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public int? Level { get; set; }

        /// <summary>
        /// <para>The name of the collection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>collectionName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that is used by the collection owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234444</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the collection owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>owner</para>
        /// </summary>
        [NameInMap("OwnerName")]
        [Validation(Required=false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// <para>The unique identifier of the collection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>album.12334</para>
        /// </summary>
        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

        /// <summary>
        /// <para>The update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1668600148617</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public long? UpdateTime { get; set; }

    }

}
