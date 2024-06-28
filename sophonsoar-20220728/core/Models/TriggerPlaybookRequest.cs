// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class TriggerPlaybookRequest : TeaModel {
        /// <summary>
        /// The input parameters of the playbook.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InputParam")]
        [Validation(Required=false)]
        public string InputParam { get; set; }

        /// <summary>
        /// The playbook UUID.
        /// 
        /// >  You can call the [DescribePlaybooks](~~DescribePlaybooks~~) operation to query the playbook UUID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

    }

}
