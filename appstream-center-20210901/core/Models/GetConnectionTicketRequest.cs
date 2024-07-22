// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetConnectionTicketRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppInstanceGroupIdList")]
        [Validation(Required=false)]
        public List<string> AppInstanceGroupIdList { get; set; }

        [NameInMap("AppInstanceId")]
        [Validation(Required=false)]
        public string AppInstanceId { get; set; }

        [NameInMap("AppInstancePersistentId")]
        [Validation(Required=false)]
        public string AppInstancePersistentId { get; set; }

        [NameInMap("AppStartParam")]
        [Validation(Required=false)]
        public string AppStartParam { get; set; }

        [NameInMap("AppVersion")]
        [Validation(Required=false)]
        public string AppVersion { get; set; }

        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
