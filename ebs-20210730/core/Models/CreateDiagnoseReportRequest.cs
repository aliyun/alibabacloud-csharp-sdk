// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class CreateDiagnoseReportRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token to ensure request idempotency. This lets you safely retry the request without creating a duplicate diagnostic report. The token can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The diagnosis type. The only valid value is:</para>
        /// <list type="bullet">
        /// <item><description>Performance: performance diagnosis</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Performance</para>
        /// </summary>
        [NameInMap("DiagnoseType")]
        [Validation(Required=false)]
        public string DiagnoseType { get; set; }

        /// <summary>
        /// <para>The end time for the diagnosis, in UTC. The time must be in the ISO 8601 format (yyyy-MM-ddTHH:mm:ssZ).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-07T16:49:25Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The region ID. Call the <a href="https://help.aliyun.com/zh/ecs/developer-reference/api-ebs-2021-07-30-describeregions?spm=a2c4g.11186623.0.i7">DescribeRegions</a> operation to find all regions supported by EBS Data Insight.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-zhangjiakou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-asb1s8***</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. The only valid value is:</para>
        /// <list type="bullet">
        /// <item><description>Disk: a cloud disk</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disk</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The start time for the diagnosis, in UTC. The time must be in the ISO 8601 format (yyyy-MM-ddTHH:mm:ssZ).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-01T02:26:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
