// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CheckUsedPropertyValueRequest : TeaModel {
        /// <summary>
        /// The property ID. You can call the [ListProperty](~~ListProperty~~) operation to query property ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PropertyId")]
        [Validation(Required=false)]
        public long? PropertyId { get; set; }

        /// <summary>
        /// The ID of the property value. You can call the [ListProperty](~~ListProperty~~) operation to query the ID of the property value.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PropertyValueId")]
        [Validation(Required=false)]
        public long? PropertyValueId { get; set; }

    }

}
