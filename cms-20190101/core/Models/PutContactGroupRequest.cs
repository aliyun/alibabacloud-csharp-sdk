// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutContactGroupRequest : TeaModel {
        /// <summary>
        /// The description of the alert contact group.
        /// </summary>
        [NameInMap("ContactGroupName")]
        [Validation(Required=false)]
        public string ContactGroupName { get; set; }

        [NameInMap("ContactNames")]
        [Validation(Required=false)]
        public List<string> ContactNames { get; set; }

        /// <summary>
        /// Specifies whether to enable the weekly report subscription feature. Valid values:
        /// 
        /// *   true: The weekly report subscription feature is enabled.
        /// *   false: The weekly report subscription feature is disabled.
        /// 
        /// >  You can enable the weekly report subscription only for an Alibaba Cloud account that has at least five Elastic Compute Service (ECS) instances.
        /// </summary>
        [NameInMap("Describe")]
        [Validation(Required=false)]
        public string Describe { get; set; }

        /// <summary>
        /// The name of the alert contact. Valid values of N: 1 to 100.
        /// </summary>
        [NameInMap("EnableSubscribed")]
        [Validation(Required=false)]
        public bool? EnableSubscribed { get; set; }

    }

}
