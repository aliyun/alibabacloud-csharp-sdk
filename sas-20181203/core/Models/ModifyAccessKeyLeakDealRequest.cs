// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyAccessKeyLeakDealRequest : TeaModel {
        /// <summary>
        /// The ID of the AccessKey pair leak.
        /// 
        /// > You can call the [DescribeAccesskeyLeakList](~~DescribeAccesskeyLeakList~~) operation to query the ID. You must specify at least one of the Id and **IdList** parameters.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The IDs of AccessKey pair leaks.
        /// </summary>
        [NameInMap("IdList")]
        [Validation(Required=false)]
        public List<long?> IdList { get; set; }

        /// <summary>
        /// The remarks that are added.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The method to handle the AccessKey pair leak. Valid values:
        /// 
        /// *   **manual**: manually handle
        /// *   **disable**: disable
        /// *   **add-whitelist**: add to the whitelist
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
