// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeSubaccountK8sClusterUserConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the internal network connection configuration is obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Obtains only the KubeConfig credentials for the internal network connection.</description></item>
        /// <item><description><c>false</c>: Obtains only the KubeConfig credentials for the public network connection.</description></item>
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
        /// <para>The validity period of the temporary KubeConfig. Unit: minutes.</para>
        /// <para>Valid values: 15 to 4320, which indicates a maximum of 3 days.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically determines a longer validity period. The specific expiration time is determined by the value of the returned expiration field.</para>
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
