// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyFullLogTtlRequest : TeaModel {
        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management. This parameter is empty by default, which indicates that the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The log storage duration of a website. Valid values: **30** to **180**. Unit: days.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
