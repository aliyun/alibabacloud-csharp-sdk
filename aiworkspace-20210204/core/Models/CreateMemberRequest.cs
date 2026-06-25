// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class CreateMemberRequest : TeaModel {
        /// <summary>
        /// <para>The list of members.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Members")]
        [Validation(Required=false)]
        public List<CreateMemberRequestMembers> Members { get; set; }
        public class CreateMemberRequestMembers : TeaModel {
            /// <summary>
            /// <para>The list of roles.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Roles")]
            [Validation(Required=false)]
            public List<string> Roles { get; set; }

            /// <summary>
            /// <para>The member IDs. Use commas (,) to separate multiple IDs. For more information, see <a href="https://help.aliyun.com/document_detail/449135.html">ListMembers</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>145883-21513926<b><b><b>88039,145883-2769726</b></b></b>87513</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
