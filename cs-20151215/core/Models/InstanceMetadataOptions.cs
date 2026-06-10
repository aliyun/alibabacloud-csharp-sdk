// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class InstanceMetadataOptions : TeaModel {
        /// <summary>
        /// <para>Configuration of the ECS instance metadata access mode. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><c>optional</c>: Compatible with both NAT mode and hardened mode.  </description></item>
        /// <item><description><c>required</c>: Enables hardened mode only (IMDSv2). After this mode is enabled, applications within edge zones cannot access ECS instance metadata through NAT mode.</description></item>
        /// </list>
        /// <para>Default Value: <c>optional</c>.  </para>
        /// <remarks>
        /// <para>Notice:   </para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is currently available only to users on the whitelist. To use it, submit a ticket to request access.  </description></item>
        /// <item><description>This parameter is supported only in ACK managed clusters of version 1.28 or later.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about instance metadata access modes, see <a href="https://help.aliyun.com/document_detail/108460.html">Instance Metadata Access Mode</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>optional</para>
        /// </summary>
        [NameInMap("http_tokens")]
        [Validation(Required=false)]
        public string HttpTokens { get; set; }

    }

}
