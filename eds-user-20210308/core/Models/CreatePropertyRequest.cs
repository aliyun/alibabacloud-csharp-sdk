// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CreatePropertyRequest : TeaModel {
        /// <summary>
        /// The property name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PropertyKey")]
        [Validation(Required=false)]
        public string PropertyKey { get; set; }

        /// <summary>
        /// The values of the property. You can specify up to 50 values for a property.
        /// </summary>
        [NameInMap("PropertyValues")]
        [Validation(Required=false)]
        public List<string> PropertyValues { get; set; }

    }

}
