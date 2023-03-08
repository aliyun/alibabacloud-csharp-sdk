// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteQualityFollowerRequest : TeaModel {
        /// <summary>
        /// The ID of the subscription relationship between the partition filter expression and the subscriber. You can call the [GetQualityFollower](~~174000~~) operation to obtain the ID of the subscription relationship.
        /// </summary>
        [NameInMap("FollowerId")]
        [Validation(Required=false)]
        public long? FollowerId { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The name of the compute engine or data source for which the partition filter expression is configured. You can log on to the [DataWorks console](https://workbench.data.aliyun.com/console) and go to the Monitoring Rules page of Data Quality to obtain the name.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

    }

}
