// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeAppServiceDetailRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6dcc8c9e-d3da-478a-a066-86dcf820****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the MSE Nacos instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-cn-sco3r0u****</para>
        /// </summary>
        [NameInMap("NacosInstanceId")]
        [Validation(Required=false)]
        public string NacosInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the MSE Nacos namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("NacosNamespaceId")]
        [Validation(Required=false)]
        public string NacosNamespaceId { get; set; }

        /// <summary>
        /// <para>The service group. This is a custom parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>springCloud</para>
        /// </summary>
        [NameInMap("ServiceGroup")]
        [Validation(Required=false)]
        public string ServiceGroup { get; set; }

        /// <summary>
        /// <para>The service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edas.service.provider</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>dubbo</b></para>
        /// </description></item>
        /// <item><description><para><b>springCloud</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>springCloud</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The service version. This is a custom parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("ServiceVersion")]
        [Validation(Required=false)]
        public string ServiceVersion { get; set; }

    }

}
