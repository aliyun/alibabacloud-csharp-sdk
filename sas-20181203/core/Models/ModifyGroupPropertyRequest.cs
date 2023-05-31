// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyGroupPropertyRequest : TeaModel {
        /// <summary>
        /// The new attributes of the server group. You can specify the following parameters to configure the attributes:
        /// 
        /// *   **groupFlag**: the type of the server group. Valid values: 0 and 1. The value **0** specifies the Default server group. The value **1** specifies other server groups.
        /// *   **groupId**: the ID of the server group.
        /// *   **groupIndex**: no meaning. You can leave this parameter empty.
        /// *   **groupName**: the name of the server group. The value is the new name of the server group. The new name cannot be the same as the original name of the server group.
        /// 
        /// >  You can call the [DescribeAllGroups](~~DescribeAllGroups~~) operation to obtain the values of the groupFlag and groupId parameters. You cannot change the value of the groupFlag or groupId parameter. You can change only the value of the groupName parameter.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

    }

}
