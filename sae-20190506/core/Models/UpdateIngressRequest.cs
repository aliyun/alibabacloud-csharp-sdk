// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateIngressRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>188077086902****_176993d****_181437****_108724****</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>87<em><b>35-cn-hangzhou,812</b></em>3-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertIds")]
        [Validation(Required=false)]
        public string CertIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;appId&quot;:&quot;395b60e4-0550-458d-9c54-a265d036****&quot;,&quot;containerPort&quot;:8080}</para>
        /// </summary>
        [NameInMap("DefaultRule")]
        [Validation(Required=false)]
        public string DefaultRule { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ingress-sae-test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>87</para>
        /// </summary>
        [NameInMap("IngressId")]
        [Validation(Required=false)]
        public long? IngressId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public string ListenerPort { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>clb</para>
        /// </summary>
        [NameInMap("LoadBalanceType")]
        [Validation(Required=false)]
        public string LoadBalanceType { get; set; }

        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;appId&quot;:&quot;395b60e4-0550-458d-9c54-a265d036****&quot;,&quot;containerPort&quot;:8080,&quot;domain&quot;:&quot;<a href="http://www.sae.site%22,%22path%22:%22/path1%22%7D,%7B%22appId%22:%22666403ce-d25b-47cf-87fe-497565d2****%22,%22containerPort%22:8080,%22domain%22:%22sae.site%22,%22path%22:%22/path2%22%7D%5D">www.sae.site&quot;,&quot;path&quot;:&quot;/path1&quot;},{&quot;appId&quot;:&quot;666403ce-d25b-47cf-87fe-497565d2****&quot;,&quot;containerPort&quot;:8080,&quot;domain&quot;:&quot;sae.site&quot;,&quot;path&quot;:&quot;/path2&quot;}]</a></para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

    }

}
