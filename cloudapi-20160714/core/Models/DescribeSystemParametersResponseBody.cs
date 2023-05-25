// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeSystemParametersResponseBody : TeaModel {
        /// <summary>
        /// Examples
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The description of a parameter.
        /// </summary>
        [NameInMap("SystemParams")]
        [Validation(Required=false)]
        public DescribeSystemParametersResponseBodySystemParams SystemParams { get; set; }
        public class DescribeSystemParametersResponseBodySystemParams : TeaModel {
            [NameInMap("SystemParamItem")]
            [Validation(Required=false)]
            public List<DescribeSystemParametersResponseBodySystemParamsSystemParamItem> SystemParamItem { get; set; }
            public class DescribeSystemParametersResponseBodySystemParamsSystemParamItem : TeaModel {
                /// <summary>
                /// Client IP Address
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// *   This API is intended for API callers.
                /// *   The response of this API contains the system parameters that are optional in API definitions.
                /// </summary>
                [NameInMap("ParamName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                /// <summary>
                /// Queries the common parameters supported by the system.
                /// </summary>
                [NameInMap("ParamType")]
                [Validation(Required=false)]
                public string ParamType { get; set; }

            }

        }

    }

}
