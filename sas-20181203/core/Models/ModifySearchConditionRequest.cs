// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifySearchConditionRequest : TeaModel {
        /// <summary>
        /// The filter condition. The value of this parameter is in the JSON format and is case-sensitive. The value contains the following fields:
        /// 
        /// *   **filterParams**: the filter-related parameters. The value is in the JSON format. Valid values:
        /// 
        ///     *   **label**: the display name of the filter condition in the console.
        /// 
        ///     *   **value**: the settings of the filter condition. The value is in the JSON format. The value contains the following fields:
        /// 
        ///         *   **name**: the name of the field for filtering. For more information, see the value description of name.
        ///         *   **value**: the value of the field for filtering.
        /// 
        /// *   **LogicalExp**: the logical relationship among multiple filter conditions. Valid values:
        /// 
        ///     *   **OR**
        ///     *   **AND**
        /// 
        /// >  Value description of **name**:
        /// 
        /// *   If **Type** is set to **ecs**, you can call the [DescribeCriteria](~~DescribeCriteria~~) operation to query the supported filter conditions.
        /// 
        /// *   If **Type** is set to **cloud_product**, you can call the [GetCloudAssetCriteria](~~GetCloudAssetCriteria~~) operation to query the supported filter conditions.
        /// </summary>
        [NameInMap("FilterConditions")]
        [Validation(Required=false)]
        public string FilterConditions { get; set; }

        /// <summary>
        /// The name of the common filter condition.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The source IP address of the request. You do not need to specify this parameter. It is automatically obtained by the system.
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// The type of the asset. Default value: **ecs**. Valid values:
        /// 
        /// *   **ecs**: host
        /// *   **cloud_product**: Alibaba Cloud service
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
