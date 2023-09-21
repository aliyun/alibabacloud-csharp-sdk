// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCriteriaRequest : TeaModel {
        /// <summary>
        /// The type of the asset. Valid values:
        /// 
        /// *   Set the value to **ecs**, which specifies to query all Elastic Compute Service (ECS) instances.
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

        /// <summary>
        /// Specifies whether the keyword that you specify for fuzzy search can be automatically matched. Default value: **false**. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("SupportAutoTag")]
        [Validation(Required=false)]
        public bool? SupportAutoTag { get; set; }

        /// <summary>
        /// The keyword that you specify for fuzzy search when you query the asset.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
