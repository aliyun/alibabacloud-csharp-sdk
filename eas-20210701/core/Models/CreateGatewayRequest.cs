// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The resource group ID. To obtain a resource group ID, see the ResourceId field in the response of the <a href="https://help.aliyun.com/document_detail/412133.html">ListResources</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-r-4gt8twzwllfo******</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Internet access. Default value: false.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableInternet")]
        [Validation(Required=false)]
        public bool? EnableInternet { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable private access. Default value: true.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableIntranet")]
        [Validation(Required=false)]
        public bool? EnableIntranet { get; set; }

        /// <summary>
        /// <para>The instance type used by the private gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>2c4g</description></item>
        /// <item><description>4c8g</description></item>
        /// <item><description>8c16g</description></item>
        /// <item><description>16c32g</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c6.4xlarge</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The alias of the private gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mygateway1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of nodes in the private gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

    }

}
