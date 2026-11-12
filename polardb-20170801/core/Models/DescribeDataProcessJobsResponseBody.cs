// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDataProcessJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of data processing jobs.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataProcessJobsResponseBodyItems> Items { get; set; }
        public class DescribeDataProcessJobsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The time when the job was created, in RFC 3339 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-01-01T00:00:00Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the data processing job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Image data processing job</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

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
            /// <para>The ID of the data processing job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-123456</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

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
            /// <para>The ID of the region where the data processing job resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

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
            /// <para>The status of the data processing job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the template used by the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tpl-123456</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of jobs returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

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
        /// <para>The total number of jobs that match the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
