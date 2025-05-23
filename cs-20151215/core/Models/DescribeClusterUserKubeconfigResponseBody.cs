// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterUserKubeconfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The kubeconfig file of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiVersion: v1****</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The expiration time of the kubeconfig file. Format: the UTC time in the RFC3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-10T09:56:17Z</para>
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

    }

}
