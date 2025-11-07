// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class DeployApplicationGroupRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyApplication</para>
        /// </summary>
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// <para>The deployment information about the application group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{       &quot;TemplateURL&quot;: &quot;<a href="https://ros-template.oss-cn-zhangjiakou.aliyuncs.com/App_Management_Existing_Vpc_Ecs_Instance.json">https://ros-template.oss-cn-zhangjiakou.aliyuncs.com/App_Management_Existing_Vpc_Ecs_Instance.json</a>&quot;,       &quot;Parameters&quot;: {         &quot;ZoneId&quot;: &quot;cn-hangzhou-k&quot;,         &quot;ProjectName&quot;: &quot;test&quot;,         &quot;SystemDiskSize&quot;: 40,         &quot;InstanceChargeType&quot;: &quot;PostPaid&quot;,         &quot;SecurityGroupId&quot;: &quot;sg-bp1a4374akk63jl8tddy&quot;,         &quot;VSwitchId&quot;: &quot;vsw-bp1fcvc3zn0jrag86rrlm&quot;,         &quot;SystemDiskCategory&quot;: &quot;cloud_essd&quot;,         &quot;InstancePassword&quot;: &quot;******&quot;,         &quot;InternetChargeType&quot;: &quot;PayByTraffic&quot;,         &quot;InstanceCount&quot;: 1,         &quot;InternetMaxBandwidthOut&quot;: 0,         &quot;VpcId&quot;: &quot;vpc-bp1i99boyas8i8m9t3skp&quot;,         &quot;EcsImageId&quot;: &quot;centos_8_5_x64_20G_alibase_20211228.vhd&quot;,         &quot;DataDiskSize&quot;: 100,         &quot;EcsInstanceType&quot;: &quot;ecs.s6-c1m4.small&quot;,         &quot;DataDiskCategory&quot;: &quot;cloud_efficiency&quot;,         &quot;EnvironmentCommandId&quot;: &quot;c-hz028fc3g031gcg&quot;       }</para>
        /// </summary>
        [NameInMap("DeployParameters")]
        [Validation(Required=false)]
        public string DeployParameters { get; set; }

        /// <summary>
        /// <para>The name of the application group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyApplicationGroup</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the region in which you want to deploy the application group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RevisionId")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

    }

}
