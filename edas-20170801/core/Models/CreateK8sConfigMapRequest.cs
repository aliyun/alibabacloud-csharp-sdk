// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class CreateK8sConfigMapRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Kubernetes cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b07c8192-****-adf4f7447720</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The data of the ConfigMap. The value must be a JSON array string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Key&quot;:&quot;name&quot;,&quot;Value&quot;:&quot;william&quot;},{&quot;Key&quot;:&quot;age&quot;,&quot;Value&quot;:&quot;12&quot;}]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public Dictionary<string, object> Data { get; set; }

        /// <summary>
        /// <para>The name of the ConfigMap. The name must start with a letter, and can contain digits, letters, and hyphens (-). It can be up to 63 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-configmap</para>
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

    }

}
