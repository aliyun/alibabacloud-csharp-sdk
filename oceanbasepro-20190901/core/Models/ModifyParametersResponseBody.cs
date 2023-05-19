// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyParametersResponseBody : TeaModel {
        /// <summary>
        /// The operation that you want to perform.   
        /// Set the value to **ModifyParameters**.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Example 1
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public ModifyParametersResponseBodyResults Results { get; set; }
        public class ModifyParametersResponseBodyResults : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
