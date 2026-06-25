// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DeleteMembersRequest : TeaModel {
        /// <summary>
        /// <para>A list of member IDs. Separate multiple member IDs with commas (,). For more information about how to obtain member IDs, see <a href="https://help.aliyun.com/document_detail/449135.html">ListMembers</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>145883-21513926<b><b><b>88039,145883-2769726</b></b></b>87513</para>
        /// </summary>
        [NameInMap("MemberIds")]
        [Validation(Required=false)]
        public string MemberIds { get; set; }

    }

}
