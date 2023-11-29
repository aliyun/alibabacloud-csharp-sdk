// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeParametersResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether a restart is required for changes to the parameter to take effect. Valid values:   
        /// - true: A restart is required.   
        /// - false: A restart is not required.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<DescribeParametersResponseBodyParameters> Parameters { get; set; }
        public class DescribeParametersResponseBodyParameters : TeaModel {
            /// <summary>
            /// DescribeParameters
            /// </summary>
            [NameInMap("AcceptableValue")]
            [Validation(Required=false)]
            public List<string> AcceptableValue { get; set; }

            /// <summary>
            /// The ID of the OceanBase cluster.
            /// </summary>
            [NameInMap("CurrentValue")]
            [Validation(Required=false)]
            public string CurrentValue { get; set; }

            /// <summary>
            /// ```
            /// http(s)://[Endpoint]/?Action=DescribeParameters
            /// &InstanceId=ob317v4uif****
            /// &Dimension=TENANT
            /// &DimensionValue=ob2mr3oae0****
            /// &Common request parameters
            /// ```
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
            /// The request ID.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The name of the parameter.
            /// </summary>
            [NameInMap("NeedReboot")]
            [Validation(Required=false)]
            public bool? NeedReboot { get; set; }

            /// <summary>
            /// 参数是否只读
            /// </summary>
            [NameInMap("Readonly")]
            [Validation(Required=false)]
            public bool? Readonly { get; set; }

            /// <summary>
            /// {
            ///     "RequestId": "EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C",
            ///     "Parameters": [
            ///         {
            ///             "Description": "The maximum delay allowed in weak-consistency reads.",
            ///             "ValueType": "CAPACITY",
            ///             "CurrentValue": "600",
            ///             "NeedReboot": false,
            ///             "Name": "connect_timeout",
            ///             "DefaultValue": "600s",
            ///             "RejectedValue": [
            ///                 "1s"
            ///             ],
            ///             "AcceptableValue": [
            ///                 "1s"
            ///             ]
            ///         }
            ///     ]
            /// }
            /// </summary>
            [NameInMap("RejectedValue")]
            [Validation(Required=false)]
            public List<string> RejectedValue { get; set; }

            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

            /// <summary>
            /// The invalid value range of the parameter.    
            /// It is an array with two string elements, which represents a range. The first element represents the minimum value and the second element represents the maximum value.
            /// </summary>
            [NameInMap("ValueType")]
            [Validation(Required=false)]
            public string ValueType { get; set; }

        }

        /// <summary>
        /// The return result of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
