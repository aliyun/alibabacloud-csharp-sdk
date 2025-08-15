// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class CreateTrailRequest : TeaModel {
        /// <summary>
        /// <para>The read/write type of the events to be delivered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Write: write events. It is the default value.</description></item>
        /// <item><description>Read: read events.</description></item>
        /// <item><description>All: read and write events.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Write</para>
        /// </summary>
        [NameInMap("EventRW")]
        [Validation(Required=false)]
        public string EventRW { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a multi-account trail. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: creates a multi-account trail.</description></item>
        /// <item><description>false (default): creates a single-account trail.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsOrganizationTrail")]
        [Validation(Required=false)]
        public bool? IsOrganizationTrail { get; set; }

        /// <summary>
        /// <para>The ARN of the MaxCompute project to which you want to deliver events.</para>
        /// <remarks>
        /// <para> You must specify at least one of the following parameters: OssBucketName, SlsProjectArn, and MaxComputeProjectArn.</para>
        /// </remarks>
        /// <remarks>
        /// <para> The name of the MaxCompute project must be prefixed with actiontrail_.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:odps:cn-hangzhou:15127787691****:project/actiontrail_****</para>
        /// </summary>
        [NameInMap("MaxComputeProjectArn")]
        [Validation(Required=false)]
        public string MaxComputeProjectArn { get; set; }

        /// <summary>
        /// <para>The ARN of the role that is assumed by ActionTrail to deliver events to the MaxCompute project.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, ActionTrail creates a service-linked role to create the corresponding resource. For more information, see <a href="https://help.aliyun.com/document_detail/169244.html">Manage the service-linked role</a>.</description></item>
        /// <item><description>If you specify this parameter and deliver events to the current account, you must grant the RAM role the permissions on the service-linked role for ActionTrail. If you want to deliver events to other accounts, you must attach a system policy to the RAM role. For more information about how to deliver events across Alibaba Cloud accounts, see <a href="https://help.aliyun.com/document_detail/207462.html">Deliver events across Alibaba Cloud accounts</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::15127787691****:role/aliyunserviceroleforactiontrail</para>
        /// </summary>
        [NameInMap("MaxComputeWriteRoleArn")]
        [Validation(Required=false)]
        public string MaxComputeWriteRoleArn { get; set; }

        /// <summary>
        /// <para>The name of the trail to be created.</para>
        /// <para>The name must be 6 to 36 characters in length. The name must start with a lowercase letter and can contain lowercase letters, digits, hyphens (-), and underscores (_).</para>
        /// <remarks>
        /// <para>The name must be unique within your Alibaba Cloud account.</para>
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
        /// <para>The name of the OSS bucket to which events are to be delivered.</para>
        /// <para>The name must be 3 to 63 characters in length. The name must start with a lowercase letter or a digit and can contain lowercase letters, digits, and hyphens (-).</para>
        /// <remarks>
        /// <para>You must specify at least one of the OssBucketName and SlsProjectArn parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>audit-log</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>The prefix of the log files to be stored in the destination OSS bucket. This parameter can be left empty.</para>
        /// <para>The prefix must be 6 to 32 characters in length. The prefix must start with a letter and can contain letters, digits, hyphens (-), forward slashes (/), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>at-product-account-audit-B</para>
        /// </summary>
        [NameInMap("OssKeyPrefix")]
        [Validation(Required=false)]
        public string OssKeyPrefix { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the service-linked role that is assumed by ActionTrail to deliver events to the destination Object Storage Service (OSS) bucket.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, ActionTrail creates a service-linked role to create the corresponding resource. For more information, see <a href="https://help.aliyun.com/document_detail/169244.html">Manage the service-linked role</a>.</description></item>
        /// <item><description>If you specify this parameter and deliver events to the current account, you must grant the RAM role the permissions on the service-linked role for ActionTrail. If you want to deliver events to other accounts, you must attach a system policy to the RAM role. For more information about how to deliver events across Alibaba Cloud accounts, see <a href="https://help.aliyun.com/document_detail/207462.html">Deliver events across Alibaba Cloud accounts</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::***:role/aliyunserviceroleforactiontrail</para>
        /// </summary>
        [NameInMap("OssWriteRoleArn")]
        [Validation(Required=false)]
        public string OssWriteRoleArn { get; set; }

        /// <summary>
        /// <para>The ARN of the Log Service project to which events are to be delivered.</para>
        /// <remarks>
        /// <para>You must specify at least one of the OssBucketName and SlsProjectArn parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:log:cn-shanghai::project/***</para>
        /// </summary>
        [NameInMap("SlsProjectArn")]
        [Validation(Required=false)]
        public string SlsProjectArn { get; set; }

        /// <summary>
        /// <para>The ARN of the RAM role that is assumed by ActionTrail to deliver events to the Log Service project.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, ActionTrail creates a service-linked role to create the corresponding resource. For more information, see <a href="https://help.aliyun.com/document_detail/169244.html">Manage the service-linked role</a>.</description></item>
        /// <item><description>If you specify this parameter, you must grant the permissions of the service-linked role that is assumed by ActionTrail to the RAM role before you can deliver events to your Alibaba Cloud account. If you need to deliver events to other Alibaba Cloud accounts, you must attach the permission policy that is used to grant permissions related to event delivery to the RAM role. For more information about how to deliver events across Alibaba Cloud accounts, see <a href="https://help.aliyun.com/document_detail/207462.html">Deliver events across Alibaba Cloud accounts</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::***:role/aliyunserviceroleforactiontrail</para>
        /// </summary>
        [NameInMap("SlsWriteRoleArn")]
        [Validation(Required=false)]
        public string SlsWriteRoleArn { get; set; }

        /// <summary>
        /// <para>The one or more regions from which the trail delivers events.</para>
        /// <para>The default value is All, which indicates that the trail delivers events from all regions.</para>
        /// <para>You can also specify specific regions. You can call the <a href="https://help.aliyun.com/document_detail/213597.html">DescribeRegions</a> operation to query all the supported regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("TrailRegion")]
        [Validation(Required=false)]
        public string TrailRegion { get; set; }

    }

}
