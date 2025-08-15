// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class CreateTrailResponseBody : TeaModel {
        /// <summary>
        /// <para>The read/write type of the events to be delivered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Write</para>
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
        /// <para>ARN of the Big Data Compute Service project for tracking delivery.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:odps:cn-hangzhou:151266687691****:project/actiontrail_****</para>
        /// </summary>
        [NameInMap("MaxComputeProjectArn")]
        [Validation(Required=false)]
        public string MaxComputeProjectArn { get; set; }

        /// <summary>
        /// <para>The ARN of the role that Operation Audit assumes when delivering operation events to the Big Data Compute Service project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::151266687691****:role/aliyunserviceroleforactiontrail</para>
        /// </summary>
        [NameInMap("MaxComputeWriteRoleArn")]
        [Validation(Required=false)]
        public string MaxComputeWriteRoleArn { get; set; }

        /// <summary>
        /// <para>The name of the trail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trail-test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket to which events are to be delivered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>audit-log</para>
        /// </summary>
        [NameInMap("OssBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        /// <summary>
        /// <para>The prefix of the log files to be stored in the destination OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>at-product-account-audit-B</para>
        /// </summary>
        [NameInMap("OssKeyPrefix")]
        [Validation(Required=false)]
        public string OssKeyPrefix { get; set; }

        /// <summary>
        /// <para>The ARN of the service-linked role that is assumed by ActionTrail to deliver events to the destination OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::***:role/aliyunserviceroleforactiontrail</para>
        /// </summary>
        [NameInMap("OssWriteRoleArn")]
        [Validation(Required=false)]
        public string OssWriteRoleArn { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>442DDADF-DA58-4029-8E8B-82C73E9A7A70</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ARN of the Log Service project to which events are to be delivered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:log:cn-hangzhou:151266687691****:project/test-project</para>
        /// </summary>
        [NameInMap("SlsProjectArn")]
        [Validation(Required=false)]
        public string SlsProjectArn { get; set; }

        /// <summary>
        /// <para>The ARN of the service-linked role that is assumed by ActionTrail to deliver events to the destination Log Service project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::***:role/aliyunserviceroleforactiontrail</para>
        /// </summary>
        [NameInMap("SlsWriteRoleArn")]
        [Validation(Required=false)]
        public string SlsWriteRoleArn { get; set; }

        /// <summary>
        /// <para>The one or more regions from which the trail delivers events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("TrailRegion")]
        [Validation(Required=false)]
        public string TrailRegion { get; set; }

    }

}
