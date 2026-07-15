// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeProtocolMountTargetRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotence of the request. Generate a unique parameter value from your client to ensure that the value is unique among different requests.</para>
        /// <para>ClientToken supports only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the RequestId of the API request as the ClientToken. The RequestId may vary for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The file system ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-099394bd928c****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The filter keys for querying protocol service export directories.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<DescribeProtocolMountTargetRequestFilters> Filters { get; set; }
        public class DescribeProtocolMountTargetRequestFilters : TeaModel {
            /// <summary>
            /// <para>The name of the filter key.</para>
            /// <list type="bullet">
            /// <item><description><para>ProtocolServiceIds: filters by protocol service ID.</para>
            /// </description></item>
            /// <item><description><para>ExportIds: filters by export directory ID.</para>
            /// </description></item>
            /// <item><description><para>VpcIds: filters by VPC ID.</para>
            /// </description></item>
            /// <item><description><para>FsetIds: filters by fileset ID.</para>
            /// </description></item>
            /// <item><description><para>Paths: filters by the file system path that corresponds to the mount target.</para>
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
            /// <item><description><para>If Key is set to ProtocolServiceIds, set Value to a protocol service ID. You can specify up to 10 protocol service IDs. Example: <c>ptc-12345678</c> or <c>ptc-12345678,ptc-12345679</c>.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to ExportIds, set Value to an export directory ID. You can specify up to 10 export directory IDs. Example: <c>exp-12345678</c> or <c>exp-12345678,exp-12345679</c>.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to VpcIds, set Value to the VPC ID of the protocol service. You can specify up to 10 VPC IDs. Example: <c>vpc-12345678</c> or <c>vpc-12345678,vpc-12345679</c>.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to FsetIds, set Value to a fileset ID. You can specify up to 10 fileset IDs. Example: <c>fset-12345678</c> or <c>fset-12345678,fset-12345679</c>.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to Paths, set Value to the file system directory that corresponds to the mount target. You can specify up to 10 paths. Example: <c>/cpfs/mnt_1/</c> or <c>/cpfs/mnt_1/,/cpfs/mnt_2/</c>.</para>
            /// </description></item>
            /// <item><description><para>If Key is set to AccessGroupNames, set Value to the permission group name of the protocol service. You can specify up to 10 permission group names. Example: <c>ag-12345678</c> or <c>ag-12345678,ag-12345679</c>.</para>
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
        /// <para>The maximum number of results to return per query.</para>
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
        /// <para>The token used to initiate the next request when the response is truncated. You can use this token to retrieve the remaining results from where the truncation occurred.</para>
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
