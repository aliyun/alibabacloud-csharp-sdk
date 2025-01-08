// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class DeleteGroupRequest : TeaModel {
        /// <summary>
        /// <para>The name of the RAM user group.</para>
        /// <para>If you want to query the name of a RAM user group, call the <a href="https://help.aliyun.com/document_detail/28703.html">ListGroups</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dev-Team</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

    }

}
