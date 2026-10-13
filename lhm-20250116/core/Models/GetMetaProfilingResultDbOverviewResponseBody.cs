// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetMetaProfilingResultDbOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The data source-level metadata profiling overview object. For more information about each field, see the descriptions of the sub-fields.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetMetaProfilingResultDbOverviewResponseBodyData Data { get; set; }
        public class GetMetaProfilingResultDbOverviewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of catalogs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("catalogCount")]
            [Validation(Required=false)]
            public int? CatalogCount { get; set; }

            /// <summary>
            /// <para>The component ID, which is the primary key identifier of the data source component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("componentId")]
            [Validation(Required=false)]
            public long? ComponentId { get; set; }

            /// <summary>
            /// <para>The identifier of the data source component type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("componentType")]
            [Validation(Required=false)]
            public int? ComponentType { get; set; }

            /// <summary>
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds_demo</para>
            /// </summary>
            [NameInMap("dsName")]
            [Validation(Required=false)]
            public string DsName { get; set; }

            /// <summary>
            /// <para>The version of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.2.0</para>
            /// </summary>
            [NameInMap("dsVersion")]
            [Validation(Required=false)]
            public string DsVersion { get; set; }

            /// <summary>
            /// <para>The number of external tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("etTableCount")]
            [Validation(Required=false)]
            public int? EtTableCount { get; set; }

            /// <summary>
            /// <para>The number of functions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("funcCount")]
            [Validation(Required=false)]
            public int? FuncCount { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-01-16T10:00:00Z</para>
            /// </summary>
            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-19 22:00:02</para>
            /// </summary>
            [NameInMap("lastModified")]
            [Validation(Required=false)]
            public string LastModified { get; set; }

            /// <summary>
            /// <para>The number of non-partitioned tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("noPtTableCount")]
            [Validation(Required=false)]
            public int? NoPtTableCount { get; set; }

            /// <summary>
            /// <para>The number of partitions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("partitionCount")]
            [Validation(Required=false)]
            public int? PartitionCount { get; set; }

            /// <summary>
            /// <para>The number of partitioned tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ptTableCount")]
            [Validation(Required=false)]
            public int? PtTableCount { get; set; }

            /// <summary>
            /// <para>The number of data rows.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("recordCount")]
            [Validation(Required=false)]
            public long? RecordCount { get; set; }

            /// <summary>
            /// <para>The number of schemas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("schemaCount")]
            [Validation(Required=false)]
            public int? SchemaCount { get; set; }

            /// <summary>
            /// <para>The data storage size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.5</para>
            /// </summary>
            [NameInMap("storageSize")]
            [Validation(Required=false)]
            public string StorageSize { get; set; }

            /// <summary>
            /// <para>The number of tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("tableCount")]
            [Validation(Required=false)]
            public int? TableCount { get; set; }

            /// <summary>
            /// <para>The number of transactional tables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("transactionalCount")]
            [Validation(Required=false)]
            public int? TransactionalCount { get; set; }

            /// <summary>
            /// <para>The number of views.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("viewCount")]
            [Validation(Required=false)]
            public int? ViewCount { get; set; }

        }

        /// <summary>
        /// <para>The error code. It is an empty string if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message. It is an empty string if the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues related to this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4C467B38-3910-4477-9B0B-6963D83B4E72</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call failed. If the call fails, troubleshoot the issue based on the errCode and errMessage parameters.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
