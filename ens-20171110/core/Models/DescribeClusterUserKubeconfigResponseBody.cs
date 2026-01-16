// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeClusterUserKubeconfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>apiVersion: v1
        /// clusters:</para>
        /// <list type="bullet">
        /// <item><description>cluster:
        ///   certificate-authority-data: x
        ///   server: <a href="https://111.111.111.111:6443">https://111.111.111.111:6443</a>
        /// name: kubernetes
        /// contexts:</description></item>
        /// <item><description>context:
        ///   cluster: kubernetes
        ///   user: user
        /// name: eck-xxxxx
        /// current-context: eck-xxxx
        /// kind: Config
        /// preferences: {}
        /// users:</description></item>
        /// <item><description>name: user
        /// user:
        ///   client-certificate-data: x
        ///   client-key-data: x</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public object Config { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C0003E8B-B930-4F59-ADC0-0E209A9012A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
