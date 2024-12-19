// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetApplicationGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the application group.</para>
        /// </summary>
        [NameInMap("ApplicationGroup")]
        [Validation(Required=false)]
        public GetApplicationGroupResponseBodyApplicationGroup ApplicationGroup { get; set; }
        public class GetApplicationGroupResponseBodyApplicationGroup : TeaModel {
            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyApplication</para>
            /// </summary>
            [NameInMap("ApplicationName")]
            [Validation(Required=false)]
            public string ApplicationName { get; set; }

            /// <summary>
            /// <para>The source of application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;Platform&quot;:&quot;github&quot;,&quot;RepoName&quot;:&quot;wenle/springboot-ecs-sourcecode-demo&quot;,&quot;Owner&quot;:&quot;wenle&quot;,&quot;Branch&quot;:&quot;main&quot;,&quot;CommitHash&quot;:&quot;8559ff3ac7568fc7951ff63f841883ee3f06c6fe&quot;,&quot;CommitMessage&quot;:&quot;Init computenest project&quot;}</para>
            /// </summary>
            [NameInMap("ApplicationSource")]
            [Validation(Required=false)]
            public string ApplicationSource { get; set; }

            /// <summary>
            /// <para>The ID of the application group in CloudMonitor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678</para>
            /// </summary>
            [NameInMap("CmsGroupId")]
            [Validation(Required=false)]
            public string CmsGroupId { get; set; }

            /// <summary>
            /// <para>The time when the application group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-07T10:28:25Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The output of the deployment result.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{       &quot;Outputs&quot;: [         {           &quot;Description&quot;: &quot;No description given&quot;,           &quot;OutputKey&quot;: &quot;InstanceIds&quot;         }       ],       &quot;StackId&quot;: &quot;6ef4b860-f6e7-4145-8d22-f4a2a32363e1&quot;     }   }</para>
            /// </summary>
            [NameInMap("DeployOutputs")]
            [Validation(Required=false)]
            public string DeployOutputs { get; set; }

            /// <summary>
            /// <para>The configuration information of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{       &quot;TemplateURL&quot;: &quot;<a href="https://ros-template.oss-cn-zhangjiakou.aliyuncs.com/App_Management_Existing_Vpc_Ecs_Instance.json">https://ros-template.oss-cn-zhangjiakou.aliyuncs.com/App_Management_Existing_Vpc_Ecs_Instance.json</a>&quot;,       &quot;Parameters&quot;: {         &quot;ZoneId&quot;: &quot;cn-hangzhou-k&quot;,         &quot;ProjectName&quot;: &quot;test&quot;,         &quot;SystemDiskSize&quot;: 40,         &quot;InstanceChargeType&quot;: &quot;PostPaid&quot;,         &quot;SecurityGroupId&quot;: &quot;sg-bp1a4374akk63jl8tddy&quot;,         &quot;VSwitchId&quot;: &quot;vsw-bp1fcvc3zn0jrag86rrlm&quot;,         &quot;SystemDiskCategory&quot;: &quot;cloud_essd&quot;,         &quot;InstancePassword&quot;: &quot;******&quot;,         &quot;InternetChargeType&quot;: &quot;PayByTraffic&quot;,         &quot;InstanceCount&quot;: 1,         &quot;InternetMaxBandwidthOut&quot;: 0,         &quot;VpcId&quot;: &quot;vpc-bp1i99boyas8i8m9t3skp&quot;,         &quot;EcsImageId&quot;: &quot;centos_8_5_x64_20G_alibase_20211228.vhd&quot;,         &quot;DataDiskSize&quot;: 100,         &quot;EcsInstanceType&quot;: &quot;ecs.s6-c1m4.small&quot;,         &quot;DataDiskCategory&quot;: &quot;cloud_efficiency&quot;,         &quot;EnvironmentCommandId&quot;: &quot;c-hz028fc3g031gcg&quot;       }</para>
            /// </summary>
            [NameInMap("DeployParameters")]
            [Validation(Required=false)]
            public string DeployParameters { get; set; }

            /// <summary>
            /// <para>The ID of the region in which you deploy the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("DeployRegionId")]
            [Validation(Required=false)]
            public string DeployRegionId { get; set; }

            /// <summary>
            /// <para>The description of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ApplicationGroup</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("ImportTagKey")]
            [Validation(Required=false)]
            public string ImportTagKey { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("ImportTagValue")]
            [Validation(Required=false)]
            public string ImportTagValue { get; set; }

            /// <summary>
            /// <para>The name of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyApplicationGroup</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The hosted O\&amp;M configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\\&quot;PrometheusConfigMap\\&quot;:{\\&quot;Template 1\\&quot;:{\\&quot;EnablePrometheus\\&quot;:false}}}</para>
            /// </summary>
            [NameInMap("OperationMetadata")]
            [Validation(Required=false)]
            public string OperationMetadata { get; set; }

            /// <summary>
            /// <para>The creation progress of the application instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The state of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Created</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The state information of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Stack CREATE completed successfully</para>
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <para>The time when the application group was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-07T10:28:25Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92EA60ED-544D-55E9-93D9-237BE9976C0D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
