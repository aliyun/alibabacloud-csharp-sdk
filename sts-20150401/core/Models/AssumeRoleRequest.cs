// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sts20150401.Models
{
    public class AssumeRoleRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the STS token. Unit: seconds.</para>
        /// <para>Minimum value: 900. Maximum value: the value of the <c>MaxSessionDuration</c> parameter. Default value: 3600.</para>
        /// <para>You can call the CreateRole or UpdateRole operation to configure the <c>MaxSessionDuration</c> parameter. For more information, see <a href="https://help.aliyun.com/document_detail/28710.html">CreateRole</a> or <a href="https://help.aliyun.com/document_detail/28712.html">UpdateRole</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("DurationSeconds")]
        [Validation(Required=false)]
        public long? DurationSeconds { get; set; }

        /// <summary>
        /// <para>The external ID of the RAM role.</para>
        /// <para>This parameter is provided by an external party and is used to prevent the confused deputy problem. For more information, see <a href="https://help.aliyun.com/document_detail/2361741.html">Use ExternalId to prevent the confused deputy problem</a>.</para>
        /// <para>The value must be 2 to 1,224 characters in length and can contain letters, digits, and the following special characters: <c>= , . @ : / - _</c>. The regular expression for this parameter is <c>[\\w+=,.@:\\/-]*</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcd1234</para>
        /// </summary>
        [NameInMap("ExternalId")]
        [Validation(Required=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// <para>The policy that specifies the permissions of the returned STS token. You can use this parameter to grant the STS token fewer permissions than the permissions granted to the RAM role.</para>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, the permissions of the returned STS token are the permissions that are included in the value of this parameter and owned by the RAM role.</description></item>
        /// <item><description>If you do not specify this parameter, the returned STS token has all the permissions of the RAM role.</description></item>
        /// </list>
        /// <para>The value must be 1 to 2,048 characters in length.</para>
        /// <para>For more information about policy elements and sample policies, see <a href="https://help.aliyun.com/document_detail/93738.html">Policy elements</a> and <a href="https://help.aliyun.com/document_detail/210969.html">Overview of sample policies</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Statement&quot;: [{&quot;Action&quot;: [&quot;<em>&quot;],&quot;Effect&quot;: &quot;Allow&quot;,&quot;Resource&quot;: [&quot;</em>&quot;]}],&quot;Version&quot;:&quot;1&quot;}</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role.</para>
        /// <para>The trusted entity of the RAM role is an Alibaba Cloud account. For more information, see <a href="https://help.aliyun.com/document_detail/93691.html">Create a RAM role for a trusted Alibaba Cloud account</a> or <a href="https://help.aliyun.com/document_detail/28710.html">CreateRole</a>.</para>
        /// <para>Format: <c>acs:ram::&lt;account_id&gt;:role/&lt;role_name&gt;</c>.</para>
        /// <para>You can view the ARN in the RAM console or by calling operations. The following items describe the validity periods of storage addresses:</para>
        /// <list type="bullet">
        /// <item><description>For more information about how to view the ARN in the RAM console, see <a href="https://help.aliyun.com/document_detail/39744.html">How do I find the ARN of the RAM role?</a></description></item>
        /// <item><description>For more information about how to view the ARN by calling operations, see <a href="https://help.aliyun.com/document_detail/28713.html">ListRoles</a> or <a href="https://help.aliyun.com/document_detail/28711.html">GetRole</a>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/adminrole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The custom name of the role session.</para>
        /// <para>Set this parameter based on your business requirements. In most cases, you can set this parameter to the identity of the API caller. For example, you can specify a username. You can specify <c>RoleSessionName</c> to identify API callers that assume the same RAM role in ActionTrail logs. This allows you to track the users that perform the operations.</para>
        /// <para>The value must be 2 to 64 characters in length and can contain letters, digits, and the following special characters: <c>. @ - _</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alice</para>
        /// </summary>
        [NameInMap("RoleSessionName")]
        [Validation(Required=false)]
        public string RoleSessionName { get; set; }

        [NameInMap("SourceIdentity")]
        [Validation(Required=false)]
        public string SourceIdentity { get; set; }

    }

}
