// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMonitorGroupRequest : TeaModel {
        /// <summary>
        /// The alert groups that receive alert notifications for the application group. The alarm notifications for the application group are sent to the alert contacts in the alarm groups.
        /// 
        /// >  An alert group is a group of one or more alert contacts. For more information about how to create alert contacts and alert groups, see [PutContact](~~114923~~) and [PutContactGroup](~~114929~~).
        /// </summary>
        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public string ContactGroups { get; set; }

        /// <summary>
        /// The name of the application group.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
