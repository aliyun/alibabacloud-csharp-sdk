// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListCdsFilesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the enterprise drive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+cds-320357****</para>
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        /// <summary>
        /// <para>The ID of the user to which the network disk is assigned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testUser</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// <para>The IDs of the files to be queried.</para>
        /// </summary>
        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public string FileIdsShrink { get; set; }

        /// <summary>
        /// <para>The ID of the team space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg-i1ruuudp92qpj****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token. Set the value to the value of the <c>NextToken</c> parameter returned in the last call to the operation. You do not need to set this parameter when you call the operation for the first time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WyI2Mzg4MjAwMzFhNGQwZWVmN2I3MjRkZjZhZjAyMWU4YzY1MmRjZmUyIiwibiIsIm4iLDEsLTEsMTY2OTg2NTQ3NTMxMiwiNjM4ODIwMDNlNTU0YmZiZjFkYTk0MmEyYTZhMjEyZDkxODdjMjAy****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sorting method of the files.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateTimeDesc: sorts the by creation time in descending order.</description></item>
        /// <item><description>ModifiedTimeAsc: sort the by modification time in ascending order.</description></item>
        /// <item><description>NameDesc: sorts the by file name in descending order.</description></item>
        /// <item><description>SizeAsc: sorts by file size in ascending order.</description></item>
        /// <item><description>ModifiedTimeDesc: sort the by modification time in descending order.</description></item>
        /// <item><description>CreateTimeAsc: sorts the by creation time in ascending order.</description></item>
        /// <item><description>SizeDesc: sorts by file size in descending order.</description></item>
        /// <item><description>NameAsc: sorts by file name in ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTimeDesc</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The parent folder ID. You can obtain the value by using the response parameter <c>FileId</c> of this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63636837e47e5a24a8a940218bef395c210e****</para>
        /// </summary>
        [NameInMap("ParentFileId")]
        [Validation(Required=false)]
        public string ParentFileId { get; set; }

        /// <summary>
        /// <para>The ID of the logon region. You can call the <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> operation to obtain the list of regions supported by cloud computers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The file status.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>available: returns only normal file.</description></item>
        /// <item><description>uploading: returns only the of objects that are being uploaded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
