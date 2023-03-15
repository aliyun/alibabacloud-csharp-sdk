// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListResourceTypesRequest : TeaModel {
        /// <summary>
        /// The entity type. Valid values:
        /// 
        /// *   All: all resource types.
        /// *   Resource: resources other than DataSource resources. For more information, see [Resources](~~28863~~).
        /// *   DataSource: DataSource resources.
        /// </summary>
        [NameInMap("EntityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

    }

}
