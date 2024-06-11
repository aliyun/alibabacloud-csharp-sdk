// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class DeleteGroupRequest : TeaModel {
        /// <summary>
        /// The name of the RAM user group.
        /// 
        /// If you want to query the name of a RAM user group, call the [ListGroups](https://help.aliyun.com/document_detail/28703.html) operation.
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

    }

}
