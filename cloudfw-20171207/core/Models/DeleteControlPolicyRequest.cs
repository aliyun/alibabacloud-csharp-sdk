// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DeleteControlPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the access control policy.</para>
        /// <para>To delete an access control policy, you must provide the unique ID of the policy. You can call the <a href="https://help.aliyun.com/document_detail/138866.html">DescribeControlPolicy</a> operation to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00281255-d220-4db1-8f4f-c4df221ad84c</para>
        /// </summary>
        [NameInMap("AclUuid")]
        [Validation(Required=false)]
        public string AclUuid { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token. Make sure that the token is unique among different requests. The token must be a string that is case-sensitive and matches the regular expression [0-9a-zA-Z-_]{1,64}. We recommend that you use a UUID. The server ensures idempotence within the validity period of 600 seconds. If you send a repeated request with the same client token and the same business parameters, the server returns the same response as the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dedeaxfedxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The traffic direction controlled by the access control policy.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: inbound traffic</description></item>
        /// <item><description><b>out</b>: outbound traffic</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. If you set this parameter to true, the system only performs prechecks on parameter validity, identity permissions, resource existence, quota limits, and dependencies. The system does not create, update, or delete actual resources, trigger actual asynchronous traffic diversion tasks, or generate downstream side effects such as billing, notifications, or callbacks. If the precheck is successful, the response includes DryRun=true, which distinguishes it from the response of an actual call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The language of the request and response.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The source IP address of the traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

    }

}
