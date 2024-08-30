// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateAlertContactGroupRequest : TeaModel {
        /// <summary>
        /// The name of the alert contact group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactGroupName")]
        [Validation(Required=false)]
        public string ContactGroupName { get; set; }

        /// <summary>
        /// The IDs of contacts in the contact group. Separate multiple contact IDs with spaces. You can call the SearchAlertContact operation to query the contact IDs. For more information, see [SearchAlertContact](https://help.aliyun.com/document_detail/130703.html).
        /// </summary>
        [NameInMap("ContactIds")]
        [Validation(Required=false)]
        public string ContactIds { get; set; }

        /// <summary>
        /// The region ID. Default value: `cn-hangzhou`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
