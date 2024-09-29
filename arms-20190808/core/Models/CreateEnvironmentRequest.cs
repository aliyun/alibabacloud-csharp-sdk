// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateEnvironmentRequest : TeaModel {
        /// <summary>
        /// <para>The language. Default value: zh.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en: English</description></item>
        /// <item><description>zh: Chinese</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <para>The ID of the resource bound to the environment, such as the container ID or VPC ID. For a Cloud environment, specify the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c6e9dec475dca4a50a188411d8cbxxx</para>
        /// </summary>
        [NameInMap("BindResourceId")]
        [Validation(Required=false)]
        public string BindResourceId { get; set; }

        /// <summary>
        /// <para>The name of the environment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env1</para>
        /// </summary>
        [NameInMap("EnvironmentName")]
        [Validation(Required=false)]
        public string EnvironmentName { get; set; }

        /// <summary>
        /// <para>The subtype of the environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CS: Container Service for Kubernetes (ACK) or Distributed Cloud Container Platform for Kubernetes (ACK One)</description></item>
        /// <item><description>ECS: ECS</description></item>
        /// <item><description>Cloud: cloud service</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS, ACK, etc.</para>
        /// </summary>
        [NameInMap("EnvironmentSubType")]
        [Validation(Required=false)]
        public string EnvironmentSubType { get; set; }

        /// <summary>
        /// <para>The type of the environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CS: Container Service</description></item>
        /// <item><description>ECS: Elastic Compute Service</description></item>
        /// <item><description>Cloud: cloud service</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CS</para>
        /// </summary>
        [NameInMap("EnvironmentType")]
        [Validation(Required=false)]
        public string EnvironmentType { get; set; }

        /// <summary>
        /// <para>The payable resource plan.</para>
        /// <list type="bullet">
        /// <item><description>If the EnvironmentType parameter is set to CS, set the value to CS_Basic or CS_Pro. Default value: CS_Basic.</description></item>
        /// <item><description>Otherwise, leave the parameter empty.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CS_Basic</para>
        /// </summary>
        [NameInMap("FeePackage")]
        [Validation(Required=false)]
        public string FeePackage { get; set; }

        /// <summary>
        /// <para>The ID of the Grafana workspace associated with the environment. If this parameter is left empty, the default shared Grafana workspace is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>grafana-rnglkcdrntlhk0****</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("GrafanaWorkspaceId")]
        [Validation(Required=false)]
        public string GrafanaWorkspaceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to initialize the environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InitEnvironment")]
        [Validation(Required=false)]
        public bool? InitEnvironment { get; set; }

        /// <summary>
        /// <para>Specifies whether agents or exporters are managed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: No. By default, no managed agents or exporters are provided for ACK clusters.</description></item>
        /// <item><description>agent: Agents are managed. By default, managed agents are provided for ASK clusters, ACS clusters, and ACK One clusters.</description></item>
        /// <item><description>agent-exporter: Agents and exporters are managed. By default, managed agents and exporters are provided for cloud services.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("ManagedType")]
        [Validation(Required=false)]
        public string ManagedType { get; set; }

        /// <summary>
        /// <para>The ID of the Prometheus instance. If no Prometheus instance is created, call the InitEnvironment operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c6e9dec475dca4a50a188411d8cbxxx</para>
        /// </summary>
        [NameInMap("PrometheusInstanceId")]
        [Validation(Required=false)]
        public string PrometheusInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxyexli2****</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags of the instance. You can specify this parameter to manage tags for the instance.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateEnvironmentRequestTags> Tags { get; set; }
        public class CreateEnvironmentRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
