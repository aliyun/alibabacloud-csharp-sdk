// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class GetProtocolMountTargetRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can generate the value on your client to ensure that the value is unique across different requests.</para>
        /// <para>The ClientToken parameter supports only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
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
        /// <para>The ID of the protocol service export directory. <b>Required</b>.</para>
        /// <para><b>How to obtain</b>:</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="https://www.alibabacloud.com/help/en/cpfs/cpfsonecs/developer-reference/api-nas-2017-06-26-createprotocolmounttarget-cpfs">CreateProtocolMountTarget</a> operation to create an export directory and obtain the ExportId from the response.</description></item>
        /// <item><description>Alternatively, call the <a href="https://www.alibabacloud.com/help/en/cpfs/cpfsonecs/developer-reference/api-nas-2017-06-26-describeprotocolmounttarget-cpfs">DescribeProtocolMountTarget</a> operation to query the export directory list and obtain the ExportId from the response.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-19abf5beab8d****</para>
        /// </summary>
        [NameInMap("ExportId")]
        [Validation(Required=false)]
        public string ExportId { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <list type="bullet">
        /// <item><description><para>CPFS: The ID must start with <c>cpfs-</c>, such as cpfs-125487****.</para>
        /// </description></item>
        /// <item><description><para>CPFS for Lingjun: The ID must start with <c>bmcpfs-</c>, such as bmcpfs-0015****.</para>
        /// </description></item>
        /// <item><description><para>CPFS SE: The ID must start with <c>cpfsse-</c>, such as cpfsse-022c71b134****.</para>
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
        /// <para>The next token. If the response is truncated, you can use NextToken to send another request to retrieve the remaining results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>M18xMA==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the protocol service. <b>Required</b>.</para>
        /// <para><b>How to obtain</b>: Call the <a href="https://www.alibabacloud.com/help/en/cpfs/cpfsonecs/developer-reference/api-nas-2017-06-26-describeprotocolservice-cpfs">DescribeProtocolService</a> operation to query the protocol service list and obtain the ProtocolServiceId from the response.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ptc-197ed6a00f2b****</para>
        /// </summary>
        [NameInMap("ProtocolServiceId")]
        [Validation(Required=false)]
        public string ProtocolServiceId { get; set; }

    }

}
