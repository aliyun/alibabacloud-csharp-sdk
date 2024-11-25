// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCClusterConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The kubeconfig file of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apiVersion: v1****</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The expiration time of the kubeconfig file. Format: the UTC time in the RFC3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-10T09:56:17Z</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9DD55F4-1A5F-48CA-BA57-DFB3CA8C4C34</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
