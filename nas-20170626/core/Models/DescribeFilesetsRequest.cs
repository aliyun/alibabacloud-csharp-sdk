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
        /// <item><description><para>CPFS: Must start with <c>cpfs-</c>, such as cpfs-099394bd928c****.</para>
        /// </description></item>
        /// <item><description><para>CPFS for Lingjun: Must start with <c>bmcpfs-</c>, such as bmcpfs-290w65p03ok64ya****.</para>
        /// <remarks>
        /// <para>This operation supports only CPFS file systems (with an ID prefix of cpfs-* or bmcpfs-*). Standard NAS and Extreme NAS file systems are not supported.</para>
        /// </remarks>
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
        /// <para>The filter conditions for the filesets to query.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeFilesetsRequestFilters> Filters { get; set; }
        public class DescribeFilesetsRequestFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FsetIds: Filters by fileset ID.</description></item>
            /// <item><description>FileSystemPath: Filters by the path of the fileset in the CPFS file system.</description></item>
            /// <item><description>Description: Filters by the description of the fileset.</description></item>
            /// <item><description>QuotaExists: Filters by whether a quota exists.<remarks>
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
            /// <para>The value of the filter key. This parameter does not support wildcards.</para>
            /// <list type="bullet">
            /// <item><description>When Key is set to FsetIds, Value is set to the fileset ID. You can specify one or more fileset IDs. You can specify up to 10 fileset IDs. Separate multiple values with commas (,). Example: <c>fset-1902718ea0ae****</c> or <c>fset-1902718ea0ae****,fset-3212718ea0ae****</c>.</description></item>
            /// <item><description>When Key is set to FileSystemPath, Value is set to the path or a part of the path of the fileset in the CPFS file system. The value must be 2 to 1,024 characters in length and encoded in UTF-8.</description></item>
            /// <item><description>When Key is set to Description, Value is set to the description or a part of the description of the fileset.</description></item>
            /// <item><description>When Key is set to QuotaExists, Value is set to true or false. If you do not specify this parameter, all filesets are returned.</description></item>
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
        /// <para>The maximum number of entries to return for a single request.</para>
        /// <para>Valid values: 10 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. If the returned results are truncated, you can use this token to initiate another request to retrieve the remaining results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cmNlU****mVzJjE1MTI2NjY4NzY5MTAzOTEmMiZORnI4NDhVeEtrUT0=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort field.</para>
        /// <list type="bullet">
        /// <item><description>FileCountLimit: The file count limit of the quota.</description></item>
        /// <item><description>SizeLimit: The capacity limit of the quota.</description></item>
        /// <item><description>FileCountUsage: The file count usage.</description></item>
        /// <item><description>SpaceUsage: The capacity usage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FileCountLimit</para>
        /// </summary>
        [NameInMap("OrderByField")]
        [Validation(Required=false)]
        public string OrderByField { get; set; }

        /// <summary>
        /// <para>The sort order.</para>
        /// <list type="bullet">
        /// <item><description>asc (default): Ascending order. Results are sorted from smallest to largest.</description></item>
        /// <item><description>desc: Descending order. Results are sorted from largest to smallest.<remarks>
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
