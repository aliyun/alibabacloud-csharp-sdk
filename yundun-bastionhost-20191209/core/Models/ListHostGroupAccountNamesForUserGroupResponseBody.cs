// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListHostGroupAccountNamesForUserGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The names of host accounts returned.</para>
        /// </summary>
        [NameInMap("HostAccountNames")]
        [Validation(Required=false)]
        public List<string> HostAccountNames { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
