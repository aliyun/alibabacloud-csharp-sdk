// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateParameterGroupResponseBody : TeaModel {
        /// <summary>
        /// The ID of the parameter template.
        /// 
        /// > You can call the [DescribeParameterGroups](~~207178~~) operation to query the details of all parameter templates of a specified region, such as the ID of a parameter template.
        /// </summary>
        [NameInMap("ParameterGroupId")]
        [Validation(Required=false)]
        public string ParameterGroupId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
