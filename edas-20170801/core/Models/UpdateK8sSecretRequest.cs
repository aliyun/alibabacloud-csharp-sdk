// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateK8sSecretRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the data has been encoded in Base64.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Base64Encoded")]
        [Validation(Required=false)]
        public bool? Base64Encoded { get; set; }

        /// <summary>
        /// <para>The ID of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6650277</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        /// <summary>
        /// <para>The region ID of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertRegionId")]
        [Validation(Required=false)]
        public string CertRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9c28bbb9-****-44b3-b953-54ef8a2d0be2</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The data of the Secret. The value must be a JSON array that contains the following information:</para>
        /// <list type="bullet">
        /// <item><description>Key: Secret key</description></item>
        /// <item><description>Value: Secret value</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Key&quot;:&quot;name&quot;,&quot;Value&quot;:&quot;william&quot;},{&quot;Key&quot;:&quot;age&quot;,&quot;Value&quot;:&quot;12&quot;}]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The name of the Secret. The name must start with a letter, and can contain digits, letters, and hyphens (-). It can be up to 63 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-secret</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The namespace of the Kubernetes cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The type of the Secret. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Opaque: user-defined data type</description></item>
        /// <item><description>kubernetes.io/tls: Transport Layer Security (TLS) certificate type</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Opaque</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
