// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeParametersResponseBody : TeaModel {
        /// <summary>
        /// The information of parameters.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<DescribeParametersResponseBodyParameters> Parameters { get; set; }
        public class DescribeParametersResponseBodyParameters : TeaModel {
            /// <summary>
            /// The valid value range of the parameter.  It is an array with two string elements, which represents a range. The first element represents the minimum value and the second element represents the maximum value.
            /// </summary>
            [NameInMap("AcceptableValue")]
            [Validation(Required=false)]
            public List<string> AcceptableValue { get; set; }

            /// <summary>
            /// The current value of the parameter.
            /// </summary>
            [NameInMap("CurrentValue")]
            [Validation(Required=false)]
            public string CurrentValue { get; set; }

            /// <summary>
            /// The default value of the parameter.
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// The description of the parameter.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the parameter.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Indicates whether a restart is required for changes to the parameter to take effect. Valid values:   
            /// - true: A restart is required.   
            /// - false: A restart is not required.
            /// </summary>
            [NameInMap("NeedReboot")]
            [Validation(Required=false)]
            public bool? NeedReboot { get; set; }

            /// <summary>
            /// The invalid value range of the parameter.    
            /// It is an array with two string elements, which represents a range. The first element represents the minimum value and the second element represents the maximum value.
            /// </summary>
            [NameInMap("RejectedValue")]
            [Validation(Required=false)]
            public List<string> RejectedValue { get; set; }

            /// <summary>
            /// The type of the parameter value.    Valid values:   
            /// - ENUM: an enumeration value.   
            /// - RANGE: a value range.   
            /// - TIME: a time value.   
            /// - CAPACITY: a storage capacity, in KB, MB, or GB.
            /// </summary>
            [NameInMap("ValueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
