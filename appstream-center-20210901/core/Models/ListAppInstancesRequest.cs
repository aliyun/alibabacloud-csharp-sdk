// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListAppInstancesRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppInstanceGroupId")]
        [Validation(Required=false)]
        public string AppInstanceGroupId { get; set; }

        [NameInMap("AppInstanceId")]
        [Validation(Required=false)]
        public string AppInstanceId { get; set; }

        [NameInMap("AppInstanceIdList")]
        [Validation(Required=false)]
        public List<string> AppInstanceIdList { get; set; }

        [NameInMap("IncludeDeleted")]
        [Validation(Required=false)]
        public bool? IncludeDeleted { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public List<string> Status { get; set; }

    }

}
