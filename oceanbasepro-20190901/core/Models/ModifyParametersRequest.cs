// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyParametersRequest : TeaModel {
        /// <summary>
        /// The type of the parameter.   
        /// Valid values: CLUSTER and TENANT.
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public string Dimension { get; set; }

        /// <summary>
        /// The resource ID of the parameter type.    
        /// You can leave this parameter unspecified when you call this operation to modify cluster parameters. In the case of tenant parameters, pass the tenant ID.
        /// </summary>
        [NameInMap("DimensionValue")]
        [Validation(Required=false)]
        public string DimensionValue { get; set; }

        /// <summary>
        /// The ID of the OceanBase cluster.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The parameters.   
        /// It is a JSON array. Each object in the array has two elements: Name and Value. 
        /// 
        /// > <br>The names and values of cluster parameters that can be modified are different from those of tenant parameters. For more information, see DescribeParameters.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

    }

}
