// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFilesetsRequest : TeaModel {
        /// <summary>
        /// <para>The file system ID.</para>
        /// <list type="bullet">
        /// <item><description><para>CPFS: The ID must start with <c>cpfs-</c>, such as cpfs-099394bd928c****.</para>
        /// </description></item>
        /// <item><description><para>CPFS for Lingjun: The ID must start with <c>bmcpfs-</c>, such as bmcpfs-290w65p03ok64ya****.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-290w65p03ok64ya****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The filter key information for the filesets to query.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeFilesetsRequestFilters> Filters { get; set; }
        public class DescribeFilesetsRequestFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FsetIds: filters by fileset ID.</description></item>
            /// <item><description>FileSystemPath: filters by the path of the fileset in the CPFS file system.</description></item>
            /// <item><description>Description: filters by the description of the fileset.</description></item>
            /// <item><description>QuotaExists: filters by whether a quota exists.<remarks>
            /// <para>Only CPFS for Lingjun 2.7.0 and later support filtering by the QuotaExists parameter.</para>
            /// </remarks>
            /// </description></item>
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
            /// <item><description>If Key is set to FsetIds, Value is set to a fileset ID. You can specify one or more fileset IDs, up to 10. Separate multiple values with commas (,). Example: <c>fset-1902718ea0ae****</c> or <c>fset-1902718ea0ae****,fset-3212718ea0ae****</c>.</description></item>
            /// <item><description>If Key is set to FileSystemPath, Value is set to the full path or a partial path of the fileset in the CPFS file system. The value must be 2 to 1,024 characters in length and encoded in UTF-8.</description></item>
            /// <item><description>If Key is set to Description, Value is set to the full description or a partial description of the fileset.</description></item>
            /// <item><description>If Key is set to QuotaExists, Value is set to true or false. If you leave this parameter empty, all filesets are returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fset-1902718ea0ae****</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of results per query.</para>
        /// <para>Valid values: 10 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. If the response is truncated, you can use this token in the next request to retrieve the remaining results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cmNlU****mVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results.</para>
        /// <list type="bullet">
        /// <item><description>FileCountLimit: the quota file count limit.</description></item>
        /// <item><description>SizeLimit: the quota capacity limit.</description></item>
        /// <item><description>FileCountUsage: the file count usage.</description></item>
        /// <item><description>SpaceUsage: the capacity usage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FileCountLimit</para>
        /// </summary>
        [NameInMap("OrderByField")]
        [Validation(Required=false)]
        public string OrderByField { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc (default): ascending order, which sorts results from smallest to largest.</description></item>
        /// <item><description>desc: descending order, which sorts results from largest to smallest.<remarks>
        /// <para>This parameter takes effect only when the OrderByField parameter is specified.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}
