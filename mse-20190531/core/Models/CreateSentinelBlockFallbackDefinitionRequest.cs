// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateSentinelBlockFallbackDefinitionRequest : TeaModel {
        /// <summary>
        /// <para>The language in which you want to display the results. Valid values: zh and en. zh is the default value, which indicates Chinese. en indicates English.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The application ID, which can be omitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcde@12345</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The application name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The behavior details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;webFallbackMode&quot;:0,&quot;webRespMessage&quot;:&quot;{}&quot;,&quot;webRespStatusCode&quot;:429,&quot;webRespContentType&quot;:0}</para>
        /// </summary>
        [NameInMap("FallbackBehavior")]
        [Validation(Required=false)]
        public string FallbackBehavior { get; set; }

        /// <summary>
        /// <para>The programming language, such as Java or Go.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JAVA</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The behavior name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyFallback</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name of the Microservices Engine (MSE) namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The target resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1 Web
        /// 2 Rpc</para>
        /// </summary>
        [NameInMap("ResourceClassification")]
        [Validation(Required=false)]
        public int? ResourceClassification { get; set; }

        /// <summary>
        /// <para>The scenario, uniformly fill in default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Scenario")]
        [Validation(Required=false)]
        public string Scenario { get; set; }

        /// <summary>
        /// <para>Redundant parameter, currently ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edasmsc</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
