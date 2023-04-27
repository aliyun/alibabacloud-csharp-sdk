// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateStandardGroupRequest : TeaModel {
        /// <summary>
        /// The created security rule set.
        /// </summary>
        [NameInMap("DbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        /// <summary>
        /// The type of the database engine. For more information about the valid values of this parameter, see [DbType parameter](~~198106~~).
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The control mode. Valid values:
        /// 
        /// *   **NONE_CONTROL**: Flexible Management
        /// *   **STABLE**: Stable Change
        /// *   **COMMON**: Security Collaboration
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// The error code returned if the request fails.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
