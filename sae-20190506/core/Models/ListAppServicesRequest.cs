// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAppServicesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application. You must specify only one of the following parameters: vpcId, namespace ID, and application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>017f39b8-dfa4-4e16-a84b-1dcee4b1****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The ID of the MSE Nacos instance. This parameter is required when the registry type is set to MSE Nacos.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-cn-sco3r0u****</para>
        /// </summary>
        [NameInMap("NacosInstanceId")]
        [Validation(Required=false)]
        public string NacosInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the MSE Nacos namespace. This parameter is required when the registry type is set to MSE Nacos.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-test</para>
        /// </summary>
        [NameInMap("NacosNamespaceId")]
        [Validation(Required=false)]
        public string NacosNamespaceId { get; set; }

        /// <summary>
        /// <para>The ID of the namespace. You must specify only one of the following parameters: VPC ID, namespace ID, and application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
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
        /// <para>The registry type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: SAE Nacos</description></item>
        /// <item><description><b>1</b>: SAE built-in Nacos</description></item>
        /// <item><description><b>2</b> :MSE Nacos</description></item>
        /// <item><description><b>9</b>: SAE Kubernetes service</description></item>
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
        /// <item><description><b>dubbo</b></description></item>
        /// <item><description><b>springCloud</b></description></item>
        /// <item><description><b>hsf</b></description></item>
        /// <item><description><b>k8sService</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>springCloud</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The unique identifier of the VPC. You must specify only one of the following parameters: VPC ID, namespace ID, and application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2ze0i263cnn311nvj****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
