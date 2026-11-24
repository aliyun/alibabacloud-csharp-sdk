// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeSubaccountK8sClusterUserConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to obtain the internal network connection configuration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: obtains only the KubeConfig credentials for internal network connections</description></item>
        /// <item><description><c>false</c>: obtains only the KubeConfig credentials for public network connections</description></item>
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
        /// <para>The validity period of the temporary KubeConfig, in minutes.</para>
        /// <para>Valid values: 15 to 4320, which indicates a maximum of 3 days.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically determines a longer validity period. The specific expiration time is determined by the value of the expiration field in the response.</para>
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
