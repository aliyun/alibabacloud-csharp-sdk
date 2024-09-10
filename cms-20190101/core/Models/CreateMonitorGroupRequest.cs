// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMonitorGroupRequest : TeaModel {
        /// <summary>
        /// The alert contact group. The alert notifications of the application group are sent to the alert contacts that belong to the alert contact group.
        /// 
        /// >  An alert contact group can contain one or more alert contacts. For information about how to create alert contacts and alert contact groups, see [PutContact](~~PutContact~~) and [PutContactGroup](~~PutContactGroup~~).
        /// </summary>
        [NameInMap("ContactGroups")]
        [Validation(Required=false)]
        public string ContactGroups { get; set; }

        /// <summary>
        /// The name of the application group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
