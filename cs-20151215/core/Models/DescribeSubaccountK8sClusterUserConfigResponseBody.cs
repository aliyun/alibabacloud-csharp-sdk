// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeSubaccountK8sClusterUserConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The KubeConfig of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiVersion: v1\nclusters:\n- cluster:\n    server: <a href="https://114.55.xx.xx:6443%5C%5Cn">https://114.55.xx.xx:6443\\n</a>    certificate-authority-data: LS0tLS****</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The expiration time of the KubeConfig. Format: UTC time in RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2028-04-09T06:20:47Z</para>
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

    }

}
