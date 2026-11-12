// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDataProcessJobAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the task was created, in RFC 3339 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("CreationTime")]
        [Validation(Required=false)]
        public string CreationTime { get; set; }

        /// <summary>
        /// <para>The JSON string of the destination database connection configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Account&quot;:&quot;example_user&quot;,&quot;Password&quot;:&quot;example_password&quot;}</para>
        /// </summary>
        [NameInMap("DestinationConfig")]
        [Validation(Required=false)]
        public string DestinationConfig { get; set; }

        /// <summary>
        /// <para>The ID of the destination PolarDB cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-test123456</para>
        /// </summary>
        [NameInMap("DestinationId")]
        [Validation(Required=false)]
        public string DestinationId { get; set; }

        /// <summary>
        /// <para>The name of the destination database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testdb</para>
        /// </summary>
        [NameInMap("DestinationPath")]
        [Validation(Required=false)]
        public string DestinationPath { get; set; }

        /// <summary>
        /// <para>The type of the destination. Currently, only PolarDB is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PolarDB</para>
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// <para>The ID of the data processing task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-123456</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The name of the model used for feature extraction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model-v1</para>
        /// </summary>
        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <para>The data processing mode. Valid values: Full, Incremental, and Both.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Full</para>
        /// </summary>
        [NameInMap("ProcessingMode")]
        [Validation(Required=false)]
        public string ProcessingMode { get; set; }

        /// <summary>
        /// <para>The region ID of the region where the data processing task is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2921D843-433A-5FB3-A03B-4EC093B219F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the source PolarFS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pfs-123456</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source data path in PolarFS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/data/input</para>
        /// </summary>
        [NameInMap("SourcePath")]
        [Validation(Required=false)]
        public string SourcePath { get; set; }

        /// <summary>
        /// <para>The type of the data source. Currently, only PolarFS is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PolarFS</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The status of the data processing task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the template used by the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpl-123456</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The node templatetype. Currently, only image is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
