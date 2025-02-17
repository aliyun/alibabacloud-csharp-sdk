// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDiagnosticMetricSetRequest : TeaModel {
        /// <summary>
        /// <para>The description of the diagnostic metric set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The ID of the request.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The IDs of diagnostic metrics. You can specify up to 100 diagnostic metric IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MetricIds")]
        [Validation(Required=false)]
        public List<string> MetricIds { get; set; }

        /// <summary>
        /// <para>The name of the diagnostic metric set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The IDs of diagnostic metrics. You can specify up to 100 diagnostic metric IDs.</para>
        /// </summary>
        [NameInMap("MetricSetName")]
        [Validation(Required=false)]
        public string MetricSetName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The type of the resource.</para>
        /// <para>Default value: instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
