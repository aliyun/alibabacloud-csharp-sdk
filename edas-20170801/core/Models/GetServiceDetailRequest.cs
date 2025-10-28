// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>efbda488-7b33-432f-a40d-<b><b>0047</b></b></para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The group to which the service belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DUBBO</para>
        /// </summary>
        [NameInMap("group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        /// <summary>
        /// <para>The IP address of the service provider. Fuzzy searches are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.20.x.xx</para>
        /// </summary>
        [NameInMap("ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The ID of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou:doc-test</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The source of the data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>agent: Use this value if you use the service query feature of the latest version to pass the query result.</description></item>
        /// <item><description>registry: Use this value if you use the service query feature of the earlier version to pass the query result.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agent</para>
        /// </summary>
        [NameInMap("origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The region ID of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The type of the service registry. This parameter is deprecated. You can ignore it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nacos</para>
        /// </summary>
        [NameInMap("registryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

        /// <summary>
        /// <para>The ID of the service. This parameter is deprecated. You can ignore it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.alibabacloud.hipstershop.CartService</para>
        /// </summary>
        [NameInMap("serviceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The name of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.alibabacloud.hipstershop.CartService</para>
        /// </summary>
        [NameInMap("serviceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The type of the service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>dubbo</description></item>
        /// <item><description>springCloud</description></item>
        /// <item><description>hsf</description></item>
        /// <item><description>istio</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>springCloud</para>
        /// </summary>
        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The version of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("serviceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

        /// <summary>
        /// <para>The source of the service. Set the value to edas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edas</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
