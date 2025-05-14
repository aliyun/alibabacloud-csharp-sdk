// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeSubaccountK8sClusterUserConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster kubeconfig file. For more information about how to view the kubeconfig file content, see <a href="https://help.aliyun.com/document_detail/86494.html">Configure cluster credentials</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiVersion: v1****</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The expiration date of the kubeconfig file. The value is the UTC time displayed in RFC3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-10T09:56:17Z</para>
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

    }

}
