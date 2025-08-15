// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DescribeTrailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ED8BC689-69DA-42AC-855E-3B06C1271194</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The trails.</para>
        /// </summary>
        [NameInMap("TrailList")]
        [Validation(Required=false)]
        public List<DescribeTrailsResponseBodyTrailList> TrailList { get; set; }
        public class DescribeTrailsResponseBodyTrailList : TeaModel {
            /// <summary>
            /// <para>The time when the trail was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-01T06:27:28Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The read/write type of the events that are delivered. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Write: write events. This is the default value.</description></item>
            /// <item><description>Read: read events.</description></item>
            /// <item><description>All: read and write events.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("EventRW")]
            [Validation(Required=false)]
            public string EventRW { get; set; }

            /// <summary>
            /// <para>The home region of the trail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("HomeRegion")]
            [Validation(Required=false)]
            public string HomeRegion { get; set; }

            /// <summary>
            /// <para>Indicates whether the trail is a multi-account trail. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false (default)</description></item>
            /// <item><description>true</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsOrganizationTrail")]
            [Validation(Required=false)]
            public bool? IsOrganizationTrail { get; set; }

            /// <summary>
            /// <para>The ARN of the MaxCompute project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:odps:cn-hangzhou:141266687691****:project/actiontrail_****</para>
            /// </summary>
            [NameInMap("MaxComputeProjectArn")]
            [Validation(Required=false)]
            public string MaxComputeProjectArn { get; set; }

            /// <summary>
            /// <para>The ARN of the role that is assumed by ActionTrail to deliver events to the MaxCompute project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::141266687691****:role/aliyunserviceroleforactiontrail</para>
            /// </summary>
            [NameInMap("MaxComputeWriteRoleArn")]
            [Validation(Required=false)]
            public string MaxComputeWriteRoleArn { get; set; }

            /// <summary>
            /// <para>The name of the trail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-4</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the resource directory.</para>
            /// <remarks>
            /// <para> This parameter is returned only when the trail is a multi-account trail.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>rd-EV****</para>
            /// </summary>
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// <para>The region where the OSS bucket resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-cn-hangzhou</para>
            /// </summary>
            [NameInMap("OssBucketLocation")]
            [Validation(Required=false)]
            public string OssBucketLocation { get; set; }

            /// <summary>
            /// <para>The name of the OSS bucket to which events are delivered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>secloud</para>
            /// </summary>
            [NameInMap("OssBucketName")]
            [Validation(Required=false)]
            public string OssBucketName { get; set; }

            /// <summary>
            /// <para>The prefix of the files that are stored in the Object Storage Service (OSS) bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trail1</para>
            /// </summary>
            [NameInMap("OssKeyPrefix")]
            [Validation(Required=false)]
            public string OssKeyPrefix { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role that is assumed by ActionTrail to deliver events to the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::***:role/aliyunserviceroleforactiontrail</para>
            /// </summary>
            [NameInMap("OssWriteRoleArn")]
            [Validation(Required=false)]
            public string OssWriteRoleArn { get; set; }

            /// <summary>
            /// <para>The region where the trail resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The ARN of the Log Service project to which events are delivered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:log:cn-qingdao:159498693826****:project/zhengze-audit-log</para>
            /// </summary>
            [NameInMap("SlsProjectArn")]
            [Validation(Required=false)]
            public string SlsProjectArn { get; set; }

            /// <summary>
            /// <para>The ARN of the RAM role that is assumed by ActionTrail to deliver events to the Log Service project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::159498693826****:role/aliyunserviceroleforactiontrail</para>
            /// </summary>
            [NameInMap("SlsWriteRoleArn")]
            [Validation(Required=false)]
            public string SlsWriteRoleArn { get; set; }

            /// <summary>
            /// <para>The time when the trail was last enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-06T02:08:38Z</para>
            /// </summary>
            [NameInMap("StartLoggingTime")]
            [Validation(Required=false)]
            public string StartLoggingTime { get; set; }

            /// <summary>
            /// <para>The status of the trail. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Disable: disabled.</description></item>
            /// <item><description>Enable: enabled.</description></item>
            /// <item><description>Fresh: The trail is created but is not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the trail was last disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-06T02:09:04Z</para>
            /// </summary>
            [NameInMap("StopLoggingTime")]
            [Validation(Required=false)]
            public string StopLoggingTime { get; set; }

            /// <summary>
            /// <para>The ARN of the trail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:actiontrail:cn-hangzhou:159498693826****:trail/test-delivery-other</para>
            /// </summary>
            [NameInMap("TrailArn")]
            [Validation(Required=false)]
            public string TrailArn { get; set; }

            /// <summary>
            /// <para>The region of the trail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("TrailRegion")]
            [Validation(Required=false)]
            public string TrailRegion { get; set; }

            /// <summary>
            /// <para>The time when the configurations of the trail were last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-06T02:16:24Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
