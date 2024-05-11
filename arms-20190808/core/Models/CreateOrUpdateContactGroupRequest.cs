// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateContactGroupRequest : TeaModel {
        /// <summary>
        /// The ID of the alert contact group.
        /// 
        /// *   If you do not specify this parameter, an alert contact group is created.
        /// *   If you specify this parameter, the specified alert contact group is modified.
        /// </summary>
        [NameInMap("ContactGroupId")]
        [Validation(Required=false)]
        public long? ContactGroupId { get; set; }

        /// <summary>
        /// The name of the alert contact group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactGroupName")]
        [Validation(Required=false)]
        public string ContactGroupName { get; set; }

        /// <summary>
        /// The ID of the contact that you want to add to the contact group. Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("ContactIds")]
        [Validation(Required=false)]
        public string ContactIds { get; set; }

    }

}
