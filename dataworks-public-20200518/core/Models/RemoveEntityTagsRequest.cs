// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RemoveEntityTagsRequest : TeaModel {
        /// <summary>
        /// The unique identifier of the entity. Example: maxcompute-table.projectA.tableA.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("QualifiedName")]
        [Validation(Required=false)]
        public string QualifiedName { get; set; }

        /// <summary>
        /// The tag keys.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public List<string> TagKeys { get; set; }

    }

}
