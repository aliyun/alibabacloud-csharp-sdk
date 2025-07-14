// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetUserMFAInfoRequest : TeaModel {
        /// <summary>
        /// <para>The logon name of the RAM user. This parameter is differently set in the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>If you use a RAM user to call this operation, this parameter can be left empty. If you do not specify this parameter, information about the MFA device that is bound to the RAM user is queried.</description></item>
        /// <item><description>If you use an Alibaba Cloud account to call this operation, you must set this parameter to the logon name of the RAM user that you want to query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
