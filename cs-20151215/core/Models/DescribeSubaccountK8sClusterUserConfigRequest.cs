// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeSubaccountK8sClusterUserConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to obtain the kubeconfig file used to connect to the cluster over the internal network. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Obtain the kubeconfig file used to connect to the cluster over the internal network.</description></item>
        /// <item><description><c>false</c>: Obtain the kubeconfig file used to connect to the cluster over the Internet.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public bool? PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The validity period of the temporary kubeconfig file. Unit: minutes.</para>
        /// <para>Valid values: 15 to 4320 (three days).</para>
        /// <remarks>
        /// <para>If you leave this parameter empty, the system sets a longer validity period and returns the value in the expiration parameter of the response.</para>
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
