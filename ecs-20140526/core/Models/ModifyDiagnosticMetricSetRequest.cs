// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyDiagnosticMetricSetRequest : TeaModel {
        /// <summary>
        /// <para>The description of the diagnostic metric set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connection diagnostics</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The IDs of diagnostic metrics.</para>
        /// </summary>
        [NameInMap("MetricIds")]
        [Validation(Required=false)]
        public List<string> MetricIds { get; set; }

        /// <summary>
        /// <para>The IDs of the diagnostic metric sets.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dms-uf6i0tv2refv8wz*****</para>
        /// </summary>
        [NameInMap("MetricSetId")]
        [Validation(Required=false)]
        public string MetricSetId { get; set; }

        /// <summary>
        /// <para>The name of the diagnostic metric set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remoteConnectError</para>
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
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
