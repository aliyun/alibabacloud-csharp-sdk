/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class AliyunAccounts : TeaModel {
        /// <summary>
        /// Aliyun账号的UID
        /// </summary>
        [NameInMap("AliyunUid")]
        [Validation(Required=false)]
        public string AliyunUid { get; set; }

        /// <summary>
        /// 弹内用户的工号
        /// </summary>
        [NameInMap("EmployeeId")]
        [Validation(Required=false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 这条记录的创建时间
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// 这条记录的上次修改时间
        /// </summary>
        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

    }

}
