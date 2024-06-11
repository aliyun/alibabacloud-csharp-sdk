// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListUsersRequest : TeaModel {
        /// <summary>
        /// The `marker`. If part of a previous response is truncated, you can use this parameter to obtain the truncated part.
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// The number of entries per page. If a response is truncated because it reaches the value of MaxItems, the value of `IsTruncatedg` will be `true`.
        /// 
        /// Valid values: 1 to 1000. Default value: 100.
        /// </summary>
        [NameInMap("MaxItems")]
        [Validation(Required=false)]
        public int? MaxItems { get; set; }

    }

}
