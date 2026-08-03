// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDataFlowsRequest : TeaModel {
        /// <summary>
        /// <para>The file system ID.</para>
        /// <list type="bullet">
        /// <item><description><para>CPFS: must start with <c>cpfs-</c>, such as cpfs-125487\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// <item><description><para>CPFS for Lingjun: must start with <c>bmcpfs-</c>, such as bmcpfs-0015\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-099394bd928c****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The filter keys for querying data flows.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeDataFlowsRequestFilters> Filters { get; set; }
        public class DescribeDataFlowsRequestFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DataFlowIds: filters by data flow ID.</description></item>
            /// <item><description>FsetIds: filters by Fileset ID.</description></item>
            /// <item><description>FileSystemPath: filters by the path of the Fileset in the CPFS file system.</description></item>
            /// <item><description>SourceStorage: filters by the access path of the source storage.</description></item>
            /// <item><description>ThroughputList: filters by the transmission bandwidth of the data flow.</description></item>
            /// <item><description>Description: filters by the description of the Fileset.</description></item>
            /// <item><description>Status: filters by data flow status.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FsetIds</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter key. Wildcards are not supported for this parameter.</para>
            /// <list type="bullet">
            /// <item><description><para>If Key is set to DataFlowIds, Value is set to a data flow ID or part of a data flow ID. You can specify one or more data flow IDs. A maximum of 10 data flow IDs can be specified. Example: <c>df-194433a5be31****</c> or <c>df-194433a512a2****,df-234533a5be31****</c>.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to FsetIds, Value is set to a Fileset ID or part of a Fileset ID. You can specify one or more Fileset IDs. A maximum of 10 Fileset IDs can be specified. Example: <c>fset-1902718ea0ae****</c> or <c>fset-235718ea0ae****,fset-5122718ea0ae****</c>.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to FileSystemPath, Value is set to a path or part of a path in the CPFS file system. The value must be 1 to 1024 characters in length.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to SourceStorage, Value is set to the access path of the source storage. The maximum length is 1024 characters.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to ThroughputList, Value is set to the transmission bandwidth of the data flow. Combined queries are supported.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to Description, Value is set to the description or part of the description of the data flow.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to Status, Value is set to the data flow status.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to SourceStoragePath, Value is set to the access path of the source storage or part of the access path. The maximum length is 1024 characters.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FsetIds</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of results for each query.</para>
        /// <para>Valid values: 10 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. If the return results are truncated, use NextToken to obtain content starting from the truncation point.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cmNlU****mVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
