// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RollbackSuspEventQuaraFileRequest : TeaModel {
        /// <summary>
        /// The ID of the cloud desktop.
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        /// <summary>
        /// The ID of the quarantined file.
        /// 
        /// You can call the [DescribeSuspEventQuaraFiles](~~217947~~) operation to obtain the ID of the quarantined file.
        /// </summary>
        [NameInMap("QuaraFieldId")]
        [Validation(Required=false)]
        public int? QuaraFieldId { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
