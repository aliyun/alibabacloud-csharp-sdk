// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class CreateTrailRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the read/write type of events that the trail delivers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Write: Write events.</para>
        /// </description></item>
        /// <item><description><para>Read: Read events.</para>
        /// </description></item>
        /// <item><description><para>All (default): All read and write events.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Write</para>
        /// </summary>
        [NameInMap("EventRW")]
        [Validation(Required=false)]
        public string EventRW { get; set; }

        /// <summary>
        /// <para>Specifies whether the trail is a multi-account trail. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false (default)</para>
        /// </description></item>
        /// </list>
        /// <para>To create a trail for an organization, set this parameter to <c>true</c>. The trail will collect events from all member accounts in the organization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsOrganizationTrail")]
        [Validation(Required=false)]
        public bool? IsOrganizationTrail { get; set; }

        /// <summary>
        /// <para>The ARN of the MaxCompute project to which ActionTrail delivers events.</para>
        /// <remarks>
        /// <para>You must specify a destination for the trail by providing at least one of the following parameters: <c>OssBucketName</c>, <c>SlsProjectArn</c>, or <c>MaxComputeProjectArn</c>.</para>
        /// </remarks>
        /// <remarks>
        /// <para>The project name in the ARN must start with <c>actiontrail_</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:odps:cn-hangzhou:15127787691****:project/actiontrail_****</para>
        /// </summary>
        [NameInMap("MaxComputeProjectArn")]
        [Validation(Required=false)]
        public string MaxComputeProjectArn { get; set; }

        /// <summary>
        /// <para>The ARN of the RAM role that ActionTrail assumes to deliver events to the MaxCompute project.</para>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is not specified, ActionTrail creates a service-linked role to deliver events. For more information, see <a href="https://help.aliyun.com/document_detail/169244.html">ActionTrail service-linked role</a>.</para>
        /// </description></item>
        /// <item><description><para>If you specify a role, it must be a RAM role that you created. This role must have a trust policy that allows the ActionTrail service (\<c>actiontrail.aliyuncs.com\\</c>) to assume it. The role\&quot;s permission policy must grant permissions to write to the specified MaxCompute project. For more information about cross-account delivery, see <a href="https://help.aliyun.com/document_detail/207462.html">Deliver events from multiple Alibaba Cloud accounts to the same account</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::15127787691****:role/aliyunserviceroleforactiontrail</para>
        /// </summary>
        [NameInMap("MaxComputeWriteRoleArn")]
        [Validation(Required=false)]
        public string MaxComputeWriteRoleArn { get; set; }

        /// <summary>
        /// <para>The name of the trail.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Length: 6 to 36 characters.</para>
        /// </description></item>
        /// <item><description><para>Characters: Lowercase letters, digits, hyphens (-), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>Must start with a lowercase letter.</para>
        /// </description></item>
        /// <item><description><para>Must be uniquewithin an Alibaba Cloud account.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trail-test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket to which ActionTrail delivers events.</para>
        /// <list type="bullet">
        /// <item><description><para>Length: 3 to 63 characters.</para>
        /// </description></item>
        /// <item><description><para>Characters: Lowercase letters, digits, and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>Must start with a lowercase letter or a digit.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify a destination for the trail by providing at least one of the following parameters: <c>OssBucketName</c>, <c>SlsProjectArn</c>, or <c>MaxComputeProjectArn</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>audit-log</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>The prefix for the names of log files that ActionTrail delivers to your OSS bucket.</para>
        /// <list type="bullet">
        /// <item><description><para>Length: 6 to 32 characters.</para>
        /// </description></item>
        /// <item><description><para>Characters: Letters, digits, hyphens (-), forward slashes (/), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>Must start with a letter.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>at-product-account-audit-B</para>
        /// </summary>
        [NameInMap("OssKeyPrefix")]
        [Validation(Required=false)]
        public string OssKeyPrefix { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role that ActionTrail assumes to deliver events to the OSS bucket.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify this parameter, ActionTrail creates a service-linked role to deliver events. For more information, see <a href="https://help.aliyun.com/document_detail/169244.html">ActionTrail service-linked role</a>.</para>
        /// </description></item>
        /// <item><description><para>If you specify a role, it must be a RAM role that you created. This role must have a trust policy that allows the ActionTrail service (actiontrail.aliyuncs.com) to assume it. The role\&quot;s RAM policy must grant permissions to write to the specified OSS bucket. For more information about cross-account delivery, see <a href="https://help.aliyun.com/document_detail/207462.html">Deliver events from multiple Alibaba Cloud accounts to the same account</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::15127787691****:role/aliyunserviceroleforactiontrail</para>
        /// </summary>
        [NameInMap("OssWriteRoleArn")]
        [Validation(Required=false)]
        public string OssWriteRoleArn { get; set; }

        /// <summary>
        /// <para>The ARN of the SLS project to which ActionTrail delivers events.</para>
        /// <remarks>
        /// <para>You must specify a destination for the trail by providing at least one of the following parameters: <c>OssBucketName</c>, <c>SlsProjectArn</c>, or <c>MaxComputeProjectArn</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:log:cn-shanghai:151266687691****:project/test-project</para>
        /// </summary>
        [NameInMap("SlsProjectArn")]
        [Validation(Required=false)]
        public string SlsProjectArn { get; set; }

        /// <summary>
        /// <para>The ARN of the RAM role that ActionTrail assumes to deliver events to the SLS project.</para>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is not specified, ActionTrail creates a service-linked role to deliver events. For more information, see <a href="https://help.aliyun.com/document_detail/169244.html">ActionTrail service-linked role</a>.</para>
        /// </description></item>
        /// <item><description><para>If you specify a role, it must be a RAM role that you created. This role must have a trust policy that allows the ActionTrail service (actiontrail.aliyuncs.com) to assume it. The role\&quot;s permission policy must grant permissions to write to the specified SLS project. For more information about cross-account delivery, see <a href="https://help.aliyun.com/document_detail/207462.html">Deliver events from multiple Alibaba Cloud accounts to the same account</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::151266687691****:role/aliyunserviceroleforactiontrail</para>
        /// </summary>
        [NameInMap("SlsWriteRoleArn")]
        [Validation(Required=false)]
        public string SlsWriteRoleArn { get; set; }

        /// <summary>
        /// <para>The region in which the trail is created. By default, a trail is created in all regions and this parameter is set to <c>All</c>. To create a trail in a specific region, provide the region ID. For more information about regions, call the <a href="https://help.aliyun.com/document_detail/213597.html">DescribeRegions</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("TrailRegion")]
        [Validation(Required=false)]
        public string TrailRegion { get; set; }

    }

}
