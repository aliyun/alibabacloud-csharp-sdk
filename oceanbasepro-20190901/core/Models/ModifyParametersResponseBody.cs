// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyParametersResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The modification results.
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public ModifyParametersResponseBodyResults Results { get; set; }
        public class ModifyParametersResponseBodyResults : TeaModel {
            /// <summary>
            /// The cause of the modification failure.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// Indicates whether the parameter has been modified. Valid values:   
            /// true: The modification is successful. 
            /// false: The modification failed.
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
