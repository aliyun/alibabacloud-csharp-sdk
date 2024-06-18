// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyParameterGroupRequest : TeaModel {
        /// <summary>
        /// The modification mode of the parameter template. Valid values:
        /// 
        /// *   **Collectivity** (default): adds new parameters or modifies parameters in the original parameter template.
        /// 
        /// >  If you set the ModifyMode parameter to Collectivity, the system adds the value of the **Parameters** parameter to the original parameter template or modifies the corresponding parameters in the original parameter template. Other parameters in the original parameter template are not affected.
        /// 
        /// *   **Individual**: overwrites original parameters.
        /// 
        /// >  If you set the ModifyMode parameter to Individual, the system uses the value of the **Parameters** parameter to overwrite the parameter settings in the original parameter template.
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The new description of the parameter template. The description can be up to 200 characters in length.
        /// 
        /// > If you do not specify this parameter, the original description of the parameter template is retained.
        /// </summary>
        [NameInMap("ParameterGroupDesc")]
        [Validation(Required=false)]
        public string ParameterGroupDesc { get; set; }

        /// <summary>
        /// The parameter template ID. You can call the DescribeParameterGroups operation to query the parameter template ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ParameterGroupId")]
        [Validation(Required=false)]
        public string ParameterGroupId { get; set; }

        /// <summary>
        /// The parameter template name.
        /// 
        /// *   The name can contain letters, digits, periods (.), and underscores (_). It must start with a letter.
        /// *   It can be 8 to 64 characters in length.
        /// 
        /// > If you do not specify this parameter, the original name of the parameter template is retained.
        /// </summary>
        [NameInMap("ParameterGroupName")]
        [Validation(Required=false)]
        public string ParameterGroupName { get; set; }

        /// <summary>
        /// A JSON string that consists of parameters and their values in the parameter template. Format: {"Parameter 1":"Value of Parameter 1","Parameter 2":"Value of Parameter 2"...}. For more information about the parameters that can be modified, see [Modify the parameters of an ApsaraDB RDS for MySQL instance](https://help.aliyun.com/document_detail/96063.html) or [Modify the parameters of an ApsaraDB RDS for PostgreSQL instance](https://help.aliyun.com/document_detail/96751.html).
        /// 
        /// > 
        /// 
        /// *   If **ModifyMode** is set to **Individual** and this parameter is specified, the new parameters overwrite the parameters in the original parameter template.
        /// 
        /// *   If you set **ModifyMode** to **Collectivity** and specify this parameter, the new parameters are added to the original parameter template, or the parameters in the original parameter template are modified.
        /// *   If you do not specify this parameter, the parameters in the original parameter template remain unchanged.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
        /// 
        /// >  The region of a parameter template cannot be changed. You can call the CloneParameterGroup operation to replicate a parameter template to a specific region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID. You can call the DescribeDBInstanceAttribute operation to query the resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
