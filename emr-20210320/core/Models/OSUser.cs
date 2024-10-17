// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class OSUser : TeaModel {
        /// <summary>
        /// <para>用户组。</para>
        /// 
        /// <b>Example:</b>
        /// <para>hadoop</para>
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// <para>用户密码。</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>用户名称。</para>
        /// 
        /// <b>Example:</b>
        /// <para>王五</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
