// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeSystemParametersResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned information about system parameters. It is an array that consists of SystemParam data.
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
                /// Examples
                /// </summary>
                [NameInMap("DemoValue")]
                [Validation(Required=false)]
                public string DemoValue { get; set; }

                /// <summary>
                /// The description of a parameter.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the parameter.
                /// </summary>
                [NameInMap("ParamName")]
                [Validation(Required=false)]
                public string ParamName { get; set; }

                /// <summary>
                /// The type of the parameter.
                /// </summary>
                [NameInMap("ParamType")]
                [Validation(Required=false)]
                public string ParamType { get; set; }

            }

        }

    }

}
