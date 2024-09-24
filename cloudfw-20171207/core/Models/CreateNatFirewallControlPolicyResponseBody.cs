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
        /// <para> To modify an access control policy, you must specify the unique ID of the policy. You can call the DescribeNatFirewallControlPolicy operation to obtain the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>6504d2fb-ab36-49c3-92a6-822a56549783</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0DC783F1-B3A7-578D-8A63-687CC9B82C0A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
