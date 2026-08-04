// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class DeletePrivateAccessApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the internal network access application. You can get this value from:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="~~ListPrivateAccessApplications~~">ListPrivateAccessApplications</a>: List internal network access applications.</para>
        /// </description></item>
        /// <item><description><para><a href="~~CreatePrivateAccessApplication~~">CreatePrivateAccessApplication</a>: Create an internal network access application.</para>
        /// </description></item>
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
