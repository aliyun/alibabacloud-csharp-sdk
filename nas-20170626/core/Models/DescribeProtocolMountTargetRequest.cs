// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeProtocolMountTargetRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// <para>The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How do I ensure the idempotence?</a></para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the request ID as the client token. The request ID may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-099394bd928c****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The filter that is used to query the export directories of the protocol service.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeProtocolMountTargetRequestFilters> Filters { get; set; }
        public class DescribeProtocolMountTargetRequestFilters : TeaModel {
            /// <summary>
            /// <para>The filter name.</para>
            /// <list type="bullet">
            /// <item><description>ProtocolServiceIds: filters export directories by protocol service ID.</description></item>
            /// <item><description>ExportIds: filters export directories by export directory ID.</description></item>
            /// <item><description>VpcIds: filters export directories by virtual private cloud (VPC) ID.</description></item>
            /// <item><description>VSwitchIds: filters export directories by vSwitch ID.</description></item>
            /// <item><description>FsetIds: filters export directories by fileset ID.</description></item>
            /// <item><description>Paths: filters export directories based on the path of the file system corresponding to the mount target.</description></item>
            /// <item><description>AccessGroupNames: filters export directories by permission group name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ExportIds</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter value. This parameter does not support wildcards.</para>
            /// <list type="bullet">
            /// <item><description>If Key is set to ProtocolServiceIds, set Value to a protocol service ID. You can specify a maximum of 10 protocol service IDs. Example: <c>ptc-12345678</c> or <c>ptc-12345678,ptc-12345679</c>.</description></item>
            /// <item><description>If Key is set to ExportIds, set Value to an export directory ID. You can specify a maximum of 10 export directory IDs. Example: <c>exp-12345678</c> or <c>exp-12345678,exp-12345679</c>.</description></item>
            /// <item><description>If Key is set to VpcIds, set Value to a VPC ID of the protocol service. You can specify a maximum of 10 VPC IDs. Example: <c>vpc-12345678</c> or <c>vpc-12345678,vpc-12345679</c>.</description></item>
            /// <item><description>If Key is set to FsetIds, set Value to a fileset ID. You can specify a maximum of 10 fileset IDs. Example: <c>fset-12345678</c> or <c>fset-12345678,fset-12345679</c>.</description></item>
            /// <item><description>If Key is set to Paths, set Value to a path of the file system corresponding to the mount target. You can specify a maximum of 10 paths. Example: <c>/cpfs/mnt_1/</c> or <c>/cpfs/mnt_1/,/cpfs/mnt_2/</c>.</description></item>
            /// <item><description>If Key is set to AccessGroupNames, set Value to a permission group name for the protocol service. You can specify a maximum of 10 permission group names. Example: <c>ag-12345678</c> or <c>ag-12345678,ag-12345679</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>exp-19abf5beab8d****, exp-19acf6beaf7d****</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of results for each query.</para>
        /// <list type="bullet">
        /// <item><description>Value values: 10 to 100.</description></item>
        /// <item><description>Default value: 20.</description></item>
        /// </list>
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
        /// <para>aBcdg==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ptc-123xxx</para>
        /// </summary>
        [NameInMap("ProtocolServiceIds")]
        [Validation(Required=false)]
        public string ProtocolServiceIds { get; set; }

    }

}
