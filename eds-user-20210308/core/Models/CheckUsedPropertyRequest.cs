// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CheckUsedPropertyRequest : TeaModel {
        /// <summary>
        /// The ID of the property. You can call the [ListProperty](https://help.aliyun.com/document_detail/410890.html) operation to query the property ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PropertyId")]
        [Validation(Required=false)]
        public long? PropertyId { get; set; }

    }

}
