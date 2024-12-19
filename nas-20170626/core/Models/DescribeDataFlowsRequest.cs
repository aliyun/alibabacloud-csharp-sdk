// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeDataFlowsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <list type="bullet">
        /// <item><description>The IDs of CPFS file systems must start with <c>cpfs-</c>. Example: cpfs-125487\<em>\</em>\<em>\</em>.</description></item>
        /// <item><description>The IDs of CPFS for LINGJUN file systems must start with <c>bmcpfs-</c>. Example: bmcpfs-0015\<em>\</em>\<em>\</em>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> CPFS file systems are available only on the China site (aliyun.com).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-290w65p03ok64ya****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The filter that is used to query data flows.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeDataFlowsRequestFilters> Filters { get; set; }
        public class DescribeDataFlowsRequestFilters : TeaModel {
            /// <summary>
            /// <para>The filter name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DataFlowIds: filters data flows by data flow ID.</description></item>
            /// <item><description>FsetIds: filters data flows by fileset ID.</description></item>
            /// <item><description>FileSystemPath: filters data flows based on the path of a fileset in a CPFS file system.</description></item>
            /// <item><description>SourceStorage: filters data flows based on the access path of the source storage.</description></item>
            /// <item><description>ThroughputList: filters data flows based on data flow throughput.</description></item>
            /// <item><description>Description: filters data flows based on the fileset description.</description></item>
            /// <item><description>Status: filters data flows based on data flow status.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FsetIds</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value. This parameter does not support wildcards.</para>
            /// <list type="bullet">
            /// <item><description>If Key is set to DataFlowIds, set Value to a data flow ID or a part of the data flow ID. You can specify a data flow ID or a group of data flow IDs. You can specify a maximum of 10 data flow IDs. Example: <c>df-194433a5be31****</c> or <c>df-194433a5be31****,df-184433a5be31****</c>.</description></item>
            /// <item><description>If Key is set to FsetIds, set Value to a fileset ID or a part of the fileset ID. You can specify a fileset ID or a group of fileset IDs. You can specify a maximum of 10 fileset IDs. Example: <c>fset-1902718ea0ae****</c> or <c>fset-1902718ea0ae****,fset-1242718ea0ae****</c>.</description></item>
            /// <item><description>If Key is set to FileSystemPath, set Value to the path or a part of the path of a fileset in a CPFS file system. The value of the parameter must be 1 to 1,024 characters in length.</description></item>
            /// <item><description>If Key is set to SourceStorage, set Value to the access path or a part of the access path of the source storage. The path can be up to 1,024 characters in length.</description></item>
            /// <item><description>If Key is set to ThroughputList, set Value to the data flow throughput. Combined query is supported.</description></item>
            /// <item><description>If Key is set to Description, set Value to a data flow description or a part of the data flow description.</description></item>
            /// <item><description>If Key is set to Status, set Value to the data flow status.</description></item>
            /// <item><description>If Key is set to SourceStoragePath, set Value to the access path or a part of the access path of the source storage. The path can be up to 1,024 characters in length.</description></item>
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
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cmNlU****mVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
