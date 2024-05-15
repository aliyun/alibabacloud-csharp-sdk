// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetMongoDBCurrentOpRequest : TeaModel {
        /// <summary>
        /// The `db.currentOp()` command that is used to filter sessions. For more information, see [db.currentOp()](https://docs.mongodb.com/manual/reference/method/db.currentOp/) of MongoDB Documentation.
        /// </summary>
        [NameInMap("FilterDoc")]
        [Validation(Required=false)]
        public string FilterDoc { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The node ID.
        /// 
        /// >  If you do not specify a node ID, the sessions of the primary node are queried by default.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// A reserved parameter. You do not need to specify the parameter.
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public string Role { get; set; }

    }

}
