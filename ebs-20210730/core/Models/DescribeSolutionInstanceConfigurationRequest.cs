// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeSolutionInstanceConfigurationRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotency of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The parameters.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<DescribeSolutionInstanceConfigurationRequestParameters> Parameters { get; set; }
        public class DescribeSolutionInstanceConfigurationRequestParameters : TeaModel {
            /// <summary>
            /// The key of the parameter.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// The value of the parameter.
            /// 
            /// > The Parameters parameter is optional. If you specify Parameters, you must specify ParameterValue.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the solution.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SolutionId")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

    }

}
