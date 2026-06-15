// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDiagnosticReportRequest : TeaModel {
        [NameInMap("AdditionalOptions")]
        [Validation(Required=false)]
        public Dictionary<string, string> AdditionalOptions { get; set; }

        /// <summary>
        /// <para>The end time. This parameter applies only to diagnostic metrics that do not require running Cloud Assistant commands in the guest OS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-11T14:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The diagnostic metric set ID. If this parameter is omitted, the default diagnostic metric set for ECS instances, <c>dms-instancedefault</c>, is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dms-uf6i0tv2refv8wz*****</para>
        /// </summary>
        [NameInMap("MetricSetId")]
        [Validation(Required=false)]
        public string MetricSetId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to get the latest list of Alibaba Cloud regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-uf6i0tv2refv8wz*****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The start time. This parameter applies only to diagnostic metrics that do not require running Cloud Assistant commands in the guest OS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-11T12:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
