// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RunTriggerNodeRequest : TeaModel {
        /// <summary>
        /// The ID of the DataWorks workspace to which the manually triggered node belongs. You can call the [ListProjects](https://help.aliyun.com/document_detail/178393.html) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

        /// <summary>
        /// The data timestamp of the instance that is generated for the manually triggered node.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public long? BizDate { get; set; }

        /// <summary>
        /// The scheduling time to run the manually triggered node. Set the value to a 13-digit timestamp in milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CycleTime")]
        [Validation(Required=false)]
        public long? CycleTime { get; set; }

        /// <summary>
        /// The ID of the manually triggered node. You can call the [ListNodes](https://help.aliyun.com/document_detail/173979.html) operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

    }

}
