// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Support_plan20210706.Models
{
    public class AddEnterpriseGroupMemberToTaskGroupRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E240815B72K5D3</para>
        /// </summary>
        [NameInMap("TaskOrderId")]
        [Validation(Required=false)]
        public string TaskOrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PtWoW82DJI1zcTwsT98kLIgAj7kfASzfC6StcpV7hKs=</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
