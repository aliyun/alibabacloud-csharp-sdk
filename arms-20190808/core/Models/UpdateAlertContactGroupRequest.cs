// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateAlertContactGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the alert contact group.
        /// </summary>
        [NameInMap("ContactGroupId")]
        [Validation(Required=false)]
        public long? ContactGroupId { get; set; }

        /// <summary>
        /// The name of the alert contact group.
        /// </summary>
        [NameInMap("ContactGroupName")]
        [Validation(Required=false)]
        public string ContactGroupName { get; set; }

        /// <summary>
        /// The ID of the alert contact.
        /// </summary>
        [NameInMap("ContactIds")]
        [Validation(Required=false)]
        public string ContactIds { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
