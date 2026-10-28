// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class AliyunAccounts : TeaModel {
        /// <summary>
        /// <para>The UID of the Alibaba Cloud account.</para>
        /// </summary>
        [NameInMap("AliyunUid")]
        [Validation(Required=false)]
        public string AliyunUid { get; set; }

        /// <summary>
        /// <para>The employee ID of the internal user.</para>
        /// </summary>
        [NameInMap("EmployeeId")]
        [Validation(Required=false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// <para>The creation time of the record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-18T12:52:15Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The last modification time of the record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-18T12:52:15Z</para>
        /// </summary>
        [NameInMap("GmtModifyTime")]
        [Validation(Required=false)]
        public string GmtModifyTime { get; set; }

    }

}
