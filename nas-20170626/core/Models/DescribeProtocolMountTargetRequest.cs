// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeProtocolMountTargetRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, and make sure that the token is unique across different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId of each API request may be different.</para>
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
        /// <para>The filter keys used to query the export directories of the protocol service.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeProtocolMountTargetRequestFilters> Filters { get; set; }
        public class DescribeProtocolMountTargetRequestFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ProtocolServiceIds: filters by protocol service ID.</para>
            /// </description></item>
            /// <item><description><para>ExportIds: filters by export directory ID.</para>
            /// </description></item>
            /// <item><description><para>VpcIds: filters by VPC ID.</para>
            /// </description></item>
            /// <item><description><para>FsetIds: filters by Fileset ID.</para>
            /// </description></item>
            /// <item><description><para>Paths: filters by the file system path corresponding to the mount target.</para>
            /// </description></item>
            /// <item><description><para>AccessGroupNames: filters by permission group name.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ExportIds</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter key. Wildcards are not supported.</para>
            /// <list type="bullet">
            /// <item><description><para>If Key is set to ProtocolServiceIds, set Value to the protocol service IDs. You can specify up to 10 protocol service IDs. Example: <c>ptc-12345678</c> or <c>ptc-12345678,ptc-12345679</c>.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to ExportIds, set Value to the export directory IDs. You can specify up to 10 export directory IDs. Example: <c>exp-12345678</c> or <c>exp-12345678,exp-12345679</c>.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to VpcIds, set Value to the VPC IDs of the protocol service. You can specify up to 10 VPC IDs. Example: <c>vpc-12345678</c> or <c>vpc-12345678,vpc-12345679</c>.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to FsetIds, set Value to the Fileset IDs. You can specify up to 10 Fileset IDs. Example: <c>fset-12345678</c> or <c>fset-12345678,fset-12345679</c>.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to Paths, set Value to the file system directories corresponding to the mount targets. You can specify up to 10 paths. Example: <c>/cpfs/mnt_1/</c> or <c>/cpfs/mnt_1/,/cpfs/mnt_2/</c>.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to AccessGroupNames, set Value to the permission group names of the protocol service. You can specify up to 10 permission group names. Example: <c>ag-12345678</c> or <c>ag-12345678,ag-12345679</c>.</para>
            /// </description></item>
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
        /// <para>The maximum number of entries to return for a single request.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values: 10 to 100.</para>
        /// </description></item>
        /// <item><description><para>Default value: 20.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results when the returned results are truncated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aBcdg==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of protocol service IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ptc-123xxx</para>
        /// </summary>
        [NameInMap("ProtocolServiceIds")]
        [Validation(Required=false)]
        public string ProtocolServiceIds { get; set; }

    }

}
