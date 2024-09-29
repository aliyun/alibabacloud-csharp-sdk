// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteNotificationPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the notification policy.</para>
        /// <para>For more information about how to obtain the ID of a notification policy, see <a href="https://help.aliyun.com/document_detail/2612375.html">ListNotificationPolicies</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
