// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DeleteContactGroupRequest : TeaModel {
        /// <summary>
        /// The name of the alert group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactGroupName")]
        [Validation(Required=false)]
        public string ContactGroupName { get; set; }

    }

}
