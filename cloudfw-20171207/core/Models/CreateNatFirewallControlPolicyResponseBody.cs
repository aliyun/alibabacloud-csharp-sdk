// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateNatFirewallControlPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique ID of the access control policy.</para>
        /// <remarks>
        /// <para>To modify an access control policy, you must provide its unique ID. You can call the <c>DescribeNatFirewallControlPolicy</c> operation to obtain this ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6504d2fb-ab36-49c3-92a6-*****</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0DC783F1-B3A7-578D-8A63-*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
