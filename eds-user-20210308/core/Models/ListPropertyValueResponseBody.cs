// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class ListPropertyValueResponseBody : TeaModel {
        [NameInMap("PropertyValueInfos")]
        [Validation(Required=false)]
        public List<ListPropertyValueResponseBodyPropertyValueInfos> PropertyValueInfos { get; set; }
        public class ListPropertyValueResponseBodyPropertyValueInfos : TeaModel {
            [NameInMap("PropertyValue")]
            [Validation(Required=false)]
            public string PropertyValue { get; set; }

            [NameInMap("PropertyValueId")]
            [Validation(Required=false)]
            public long? PropertyValueId { get; set; }

        }

        /// <summary>
        /// ListPropertyValue
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
