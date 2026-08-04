// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetPrivateAccessApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the internal-facing access application. You can obtain the value from:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListPrivateAccessApplications~~">ListPrivateAccessApplications</a>: Lists internal-facing access applications.</description></item>
        /// <item><description><a href="~~CreatePrivateAccessApplication~~">CreatePrivateAccessApplication</a>: Creates an internal-facing access application.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-application-e12860ef6c48****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

    }

}
