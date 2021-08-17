/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Support_plan20210706.Models
{
    public class EnterpriseDingtalkGroupMember : TeaModel {
        /// <summary>
        /// 是否企业钉群管理员
        /// </summary>
        [NameInMap("IsAdmin")]
        [Validation(Required=false)]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// 成员手机号
        /// </summary>
        [NameInMap("Mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// 成员姓名
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
