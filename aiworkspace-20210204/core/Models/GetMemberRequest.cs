// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetMemberRequest : TeaModel {
        /// <summary>
        /// <para>The member ID. You must specify only one of the following parameters: UserId and MemberId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>145883-21513926******88039</para>
        /// </summary>
        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account. You can call <a href="https://help.aliyun.com/document_detail/449133.html">ListWorkspaceUsers</a> to obtain the ID of the Alibaba Cloud account. You must specify only one of the following parameters: UserId and MemberId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21513926******88039</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
