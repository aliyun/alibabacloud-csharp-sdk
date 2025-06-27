// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateMetaCollectionRequest : TeaModel {
        /// <summary>
        /// <para>The collection administrator IDs. This parameter is available only for data albums. The administrator must be an account within the same tenant.</para>
        /// </summary>
        [NameInMap("Administrators")]
        [Validation(Required=false)]
        public List<string> Administrators { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>new comment</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The collection ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>category.123</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>new_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
