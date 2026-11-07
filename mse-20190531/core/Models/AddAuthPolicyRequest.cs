// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddAuthPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values: zh-CN (Chinese, default) and en-US (English).</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The ID of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e9clba2xlc@***</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The content of the service authentication rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;all&quot;:true,&quot;black&quot;:false,&quot;appIds&quot;:[&quot;dez4qt7weh@***&quot;]}]</para>
        /// </summary>
        [NameInMap("AuthRule")]
        [Validation(Required=false)]
        public string AuthRule { get; set; }

        /// <summary>
        /// <para>The type of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: application dimension.</description></item>
        /// <item><description>1: namespace dimension.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public int? AuthType { get; set; }

        /// <summary>
        /// <para>Specifies whether the authentication rule is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Enabled.</description></item>
        /// <item><description><c>false</c>: Disabled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// <para>The ID of the namespace in the Kubernetes cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c19c6c500e1ff4d7abc7***</para>
        /// </summary>
        [NameInMap("K8sNamespace")]
        [Validation(Required=false)]
        public string K8sNamespace { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The MSE namespace to which the application belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The protocol type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SPRING_CLOUD</b></description></item>
        /// <item><description><b>DUBBO</b></description></item>
        /// <item><description><b>istio</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SPRING_CLOUD</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The source. Valid values: edasmsc.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edasmsc</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
