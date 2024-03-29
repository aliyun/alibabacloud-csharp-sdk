// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSubscriptionMetaShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the distributed change tracking instance.
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// The ID of the region in which the change tracking instance resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the consumer group.
        /// </summary>
        [NameInMap("Sid")]
        [Validation(Required=false)]
        public string Sid { get; set; }

        /// <summary>
        /// The IDs of all subtasks in the distributed change tracking task. Separate multiple subtask IDs with commas (,).
        /// 
        /// >  You must specify at least one of the SubMigrationJobIds and **Topics** parameters. We recommend that you specify the SubMigrationJobIds parameter.
        /// </summary>
        [NameInMap("SubMigrationJobIds")]
        [Validation(Required=false)]
        public string SubMigrationJobIdsShrink { get; set; }

        /// <summary>
        /// The topics of all subtasks in the distributed change tracking task. Separate multiple topics with commas (,).
        /// 
        /// >  You must specify at least one of the **SubMigrationJobIds** and Topics parameters. We recommend that you specify the **SubMigrationJobIds** parameter.
        /// </summary>
        [NameInMap("Topics")]
        [Validation(Required=false)]
        public string TopicsShrink { get; set; }

    }

}
