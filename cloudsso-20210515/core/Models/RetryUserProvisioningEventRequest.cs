// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class RetryUserProvisioningEventRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-003qew84****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The conflict handling policy. The policy is used when a RAM user has the same username as the CloudSSO user who is synchronized to RAM. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>KeepBoth: When a CloudSSO user is synchronized to RAM, if a RAM user who has the same username as the CloudSSO user exists, the system creates a RAM user whose username is the username of the CloudSSO user plus the suffix <c>_sso</c>.</description></item>
        /// <item><description>TakeOver: When a CloudSSO user is synchronized to RAM, if a RAM user who has the same username as the CloudSSO user exists, the system replaces the RAM user with the CloudSSO user.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>KeepBoth</para>
        /// </summary>
        [NameInMap("DuplicationStrategy")]
        [Validation(Required=false)]
        public string DuplicationStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the RAM user provisioning event.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2636305.html">ListUserProvisioningEvents</a> operation to query the value of <c>EventId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>upe-wjKyNDmZvyZOiRcJ****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

    }

}
