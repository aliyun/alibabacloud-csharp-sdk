// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteAlertContactGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the alert contact group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactGroupId")]
        [Validation(Required=false)]
        public long? ContactGroupId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
