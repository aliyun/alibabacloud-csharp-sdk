// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeFilesetsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <list type="bullet">
        /// <item><description>The IDs of CPFS file systems must start with <c>cpfs-</c>. Example: cpfs-099394bd928c\<em>\</em>\<em>\</em>.</description></item>
        /// <item><description>The IDs of CPFS for LINGJUN file systems must start with <c>bmcpfs-</c>. Example: bmcpfs-290w65p03ok64ya\<em>\</em>\<em>\</em>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> CPFS is not supported on the international site.</para>
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
        /// <para>The filter that is used to query filesets.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeFilesetsRequestFilters> Filters { get; set; }
        public class DescribeFilesetsRequestFilters : TeaModel {
            /// <summary>
            /// <para>The filter name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FsetIds: filters filesets by fileset ID.</description></item>
            /// <item><description>FileSystemPath: filters filesets based on the path of a fileset in a CPFS file system.</description></item>
            /// <item><description>Description: filters filesets based on the fileset description.</description></item>
            /// <item><description>QuotaExists: filters filesets based on whether quotas exist.</description></item>
            /// </list>
            /// <remarks>
            /// <para> Only CPFS for LINGJUN V2.7.0 and later support the QuotaExists parameter.</para>
            /// </remarks>
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
            /// <item><description>If Key is set to FsetIds, set Value to a fileset ID or a part of the fileset ID. You can specify a fileset ID or a group of fileset IDs. You can specify a maximum of 10 fileset IDs. Example: <c>fset-1902718ea0ae****</c> or <c>fset-1902718ea0ae****,fset-3212718ea0ae****</c>.</description></item>
            /// <item><description>If Key is set to FileSystemPath, set Value to the path or a part of the path of a fileset in a CPFS file system. The value must be 2 to 1024 characters in length. The value must be encoded in UTF-8.</description></item>
            /// <item><description>If Key is set to Description, set Value to a fileset description or a part of the fileset description.</description></item>
            /// <item><description>If Key is set to QuotaExists, set Value to true or false. If you do not specify the parameter, all filesets are returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fset-12345678,fset-12345679</para>
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
