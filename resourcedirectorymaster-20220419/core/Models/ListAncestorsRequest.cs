// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListAncestorsRequest : TeaModel {
        /// <summary>
        /// The ID of the subfolder.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChildId")]
        [Validation(Required=false)]
        public string ChildId { get; set; }

    }

}
