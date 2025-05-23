// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterUserKubeconfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to obtain the kubeconfig file that is used to connect to the cluster over the internal network. You can obtain the terminal ID by calling one of the following operations:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: obtains the kubeconfig file that is used to connect to the master instance over the internal network.</description></item>
        /// <item><description><c>false</c>: obtains the kubeconfig file that is used to connect to the master instance over the Internet.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public bool? PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The validity period of the temporary kubeconfig file. Unit: minutes. Valid values: 15 to 4320 (3 days).</para>
        /// <para>**</para>
        /// <para><b>Usage notes</b> If you do not specify this parameter, the system specifies a longer validity period. The validity period is returned in the <c>expiration</c> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TemporaryDurationMinutes")]
        [Validation(Required=false)]
        public long? TemporaryDurationMinutes { get; set; }

    }

}
