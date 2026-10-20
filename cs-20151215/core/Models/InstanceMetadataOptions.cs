// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class InstanceMetadataOptions : Darabonba.Model {
        /// <summary>
        /// <para>The ECS instance metadata access mode configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>optional</c>: Compatible with both normal mode and hardened mode.</description></item>
        /// <item><description><c>required</c>: Enables hardened mode only (IMDSv2). After this mode is enabled, applications in the node cannot access ECS instance metadata in normal mode.</description></item>
        /// </list>
        /// <para>Default value: <c>optional</c>.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is currently available only by whitelist. To use this parameter, submit a ticket.</description></item>
        /// <item><description>Only ACK managed clusters of version 1.28 and later support this parameter.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about instance metadata access modes, see <a href="https://help.aliyun.com/document_detail/108460.html">Instance metadata access modes</a>.</para>
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

