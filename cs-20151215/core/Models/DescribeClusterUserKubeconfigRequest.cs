// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterUserKubeconfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to obtain the internal network connection configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: obtains only the internal network connection credentials.</description></item>
        /// <item><description><c>false</c>: obtains only the public network connection credentials.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public bool? PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The validity period of the temporary kubeconfig file, in minutes. Valid values: 15 to 4320.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically determines a longer validity period. You can determine the specific expiration time based on the value of the <c>expiration</c> field in the response.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TemporaryDurationMinutes")]
        [Validation(Required=false)]
        public long? TemporaryDurationMinutes { get; set; }

    }

}
