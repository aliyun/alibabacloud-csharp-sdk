// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyDtsJobDuLimitRequest : TeaModel {
        /// <summary>
        /// The ID of the data migration, data synchronization, or change tracking task.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// The upper limit of DUs for the DTS task.
        /// 
        /// >  Minimum value: **1**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DuLimit")]
        [Validation(Required=false)]
        public long? DuLimit { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The ID of the region in which the DTS instance resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
