// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAppServicesRequest : TeaModel {
        /// <summary>
        /// <para>The application ID. Specify exactly one of the following parameters: <c>VpcId</c>, <c>NamespaceId</c>, or <c>AppId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>017f39b8-dfa4-4e16-a84b-1dcee4b1****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The instance ID of MSE Nacos. This parameter is required if the service registry is MSE Nacos.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-cn-sco3r0u****</para>
        /// </summary>
        [NameInMap("NacosInstanceId")]
        [Validation(Required=false)]
        public string NacosInstanceId { get; set; }

        /// <summary>
        /// <para>The namespace ID of MSE Nacos. This parameter is required if the service registry is MSE Nacos.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-test</para>
        /// </summary>
        [NameInMap("NacosNamespaceId")]
        [Validation(Required=false)]
        public string NacosNamespaceId { get; set; }

        /// <summary>
        /// <para>The namespace ID. Specify exactly one of the following parameters: <c>VpcId</c>, <c>NamespaceId</c>, or <c>AppId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The service registry type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: SAE Nacos</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: self-managed service registry</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: MSE Nacos</para>
        /// </description></item>
        /// <item><description><para><b>9</b>: SAE K8s Service</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RegistryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

        /// <summary>
        /// <para>The service type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>dubbo</b></para>
        /// </description></item>
        /// <item><description><para><b>springCloud</b></para>
        /// </description></item>
        /// <item><description><para><b>hsf</b></para>
        /// </description></item>
        /// <item><description><para><b>k8sService</b></para>
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
        /// <para>The ID of the VPC. Specify exactly one of the following parameters: <c>VpcId</c>, <c>NamespaceId</c>, or <c>AppId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2ze0i263cnn311nvj****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
