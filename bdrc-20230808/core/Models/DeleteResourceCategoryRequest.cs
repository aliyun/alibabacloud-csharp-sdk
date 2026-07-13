// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BDRC20230808.Models
{
    public class DeleteResourceCategoryRequest : TeaModel {
        /// <summary>
        /// <para>Resource category ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-123****7890</para>
        /// </summary>
        [NameInMap("ResourceCategoryId")]
        [Validation(Required=false)]
        public string ResourceCategoryId { get; set; }

    }

}
