// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutContactGroupRequest : TeaModel {
        /// <summary>
        /// The name of the alert contact group.
        /// 
        /// For information about how to obtain the name of an alert contact group, see [DescribeContactGroupList](https://help.aliyun.com/document_detail/114922.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactGroupName")]
        [Validation(Required=false)]
        public string ContactGroupName { get; set; }

        [NameInMap("ContactNames")]
        [Validation(Required=false)]
        public List<string> ContactNames { get; set; }

        /// <summary>
        /// The description of the alert contact group.
        /// </summary>
        [NameInMap("Describe")]
        [Validation(Required=false)]
        public string Describe { get; set; }

        /// <summary>
        /// Specifies whether to enable the weekly report subscription feature. Valid values:
        /// 
        /// *   true: The weekly report subscription feature is enabled.
        /// *   false: The weekly report subscription feature is disabled.
        /// 
        /// >  You can enable the weekly report subscription only for an Alibaba Cloud account that has at least five Elastic Compute Service (ECS) instances.
        /// </summary>
        [NameInMap("EnableSubscribed")]
        [Validation(Required=false)]
        public bool? EnableSubscribed { get; set; }

    }

}
