// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListApplicationGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the application group.</para>
        /// </summary>
        [NameInMap("ApplicationGroups")]
        [Validation(Required=false)]
        public List<ListApplicationGroupsResponseBodyApplicationGroups> ApplicationGroups { get; set; }
        public class ListApplicationGroupsResponseBodyApplicationGroups : TeaModel {
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
            /// <para>The configuration information of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{   &quot;TemplateURL&quot;: &quot;<a href="https://ros-template.oss-cn-zhangjiakou.aliyuncs.com/App_Management_Existing_Vpc_Ecs_Instance.json">https://ros-template.oss-cn-zhangjiakou.aliyuncs.com/App_Management_Existing_Vpc_Ecs_Instance.json</a>&quot;,   &quot;Parameters&quot;: {     &quot;ZoneId&quot;: &quot;cn-hangzhou-k&quot;,     &quot;ProjectName&quot;: &quot;test&quot;,     &quot;SystemDiskSize&quot;: 40,     &quot;InstanceChargeType&quot;: &quot;PostPaid&quot;,     &quot;SecurityGroupId&quot;: &quot;sg-bp1a4374akk63jl8tddy&quot;,     &quot;VSwitchId&quot;: &quot;vsw-bp1fcvc3zn0jrag86rrlm&quot;,     &quot;SystemDiskCategory&quot;: &quot;cloud_essd&quot;,     &quot;InstancePassword&quot;: &quot;******&quot;,     &quot;InternetChargeType&quot;: &quot;PayByTraffic&quot;,     &quot;InstanceCount&quot;: 1,     &quot;InternetMaxBandwidthOut&quot;: 0,     &quot;VpcId&quot;: &quot;vpc-bp1i99boyas8i8m9t3skp&quot;,     &quot;EcsImageId&quot;: &quot;centos_8_5_x64_20G_alibase_20211228.vhd&quot;,     &quot;DataDiskSize&quot;: 100,     &quot;EcsInstanceType&quot;: &quot;ecs.s6-c1m4.small&quot;,     &quot;DataDiskCategory&quot;: &quot;cloud_efficiency&quot;,     &quot;EnvironmentCommandId&quot;: &quot;c-hz028fc3g031gcg&quot;   },   &quot;RegionId&quot;: &quot;cn-hangzhou&quot;,   &quot;StackName&quot;: &quot;stack-1645688523068-3no_AKhOJ&quot;,   &quot;DisableRollback&quot;: true }</para>
            /// </summary>
            [NameInMap("DeployParameters")]
            [Validation(Required=false)]
            public string DeployParameters { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the related resources reside.</para>
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

            [NameInMap("ErrorDetail")]
            [Validation(Required=false)]
            public string ErrorDetail { get; set; }

            [NameInMap("ErrorType")]
            [Validation(Required=false)]
            public string ErrorType { get; set; }

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
            /// <para>UpdateMyApplicationGroup</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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
            /// <para>ApplicationGroup is Created.</para>
            /// </summary>
            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            /// <summary>
            /// <para>The time when the application group was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-08T03:01:53Z</para>
            /// </summary>
            [NameInMap("UpdateDate")]
            [Validation(Required=false)]
            public string UpdateDate { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69D97BF2-5DF2-544C-A650-36A474E17BC3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
