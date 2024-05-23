// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifyParametersRequest : TeaModel {
        /// <summary>
        /// The ID of the OceanBase cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public string Dimension { get; set; }

        /// <summary>
        /// The cause of the modification failure.
        /// </summary>
        [NameInMap("DimensionValue")]
        [Validation(Required=false)]
        public string DimensionValue { get; set; }

        /// <summary>
        /// Alibaba Cloud CLI
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The resource ID of the parameter type.    
        /// You can leave this parameter unspecified when you call this operation to modify cluster parameters. In the case of tenant parameters, pass the tenant ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

    }

}
