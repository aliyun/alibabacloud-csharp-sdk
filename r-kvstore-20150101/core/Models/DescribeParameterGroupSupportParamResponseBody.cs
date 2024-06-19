// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeParameterGroupSupportParamResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The parameters.
        /// </summary>
        [NameInMap("ResourceList")]
        [Validation(Required=false)]
        public List<DescribeParameterGroupSupportParamResponseBodyResourceList> ResourceList { get; set; }
        public class DescribeParameterGroupSupportParamResponseBodyResourceList : TeaModel {
            /// <summary>
            /// The service category.
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// The engine type.
            /// </summary>
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// The engine version.
            /// </summary>
            [NameInMap("DbVersion")]
            [Validation(Required=false)]
            public string DbVersion { get; set; }

            /// <summary>
            /// The name of the parameter.
            /// </summary>
            [NameInMap("ParamName")]
            [Validation(Required=false)]
            public string ParamName { get; set; }

        }

    }

}
