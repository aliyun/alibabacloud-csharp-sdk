// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class SetFilesetQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// <para>The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for this request.
        /// A dry run checks parameter validity and dependencies without actually deleting the instance or incurring charges.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Sends a check request without deleting the export directory. The check items include whether required parameters are specified, the request format, and business limit dependencies. If the check fails, the corresponding error is returned. If the check passes, HTTP status code 200 is returned.</para>
        /// </description></item>
        /// <item><description><para>false (default): Sends a normal request. After the check passes, the instance is directly deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The file count limit of the quota. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Minimum value: 10,000.</para>
        /// </description></item>
        /// <item><description><para>Maximum value: 10,000,000,000.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, the file count is unlimited.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("FileCountLimit")]
        [Validation(Required=false)]
        public long? FileCountLimit { get; set; }

        /// <summary>
        /// <para>The ID of the CPFS for Lingjun file system. The ID must start with <c>bmcpfs-</c>, such as bmcpfs-290w65p03ok64ya****. You can call <a href="https://www.alibabacloud.com/help/en/nas/developer-reference/api-nas-2017-06-26-describefilesystems">DescribeFileSystems</a> (FileSystemType=bmcpfs) to query existing file systems.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-290w65p03ok64ya****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>Fileset ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fset-1902718ea0ae****</para>
        /// </summary>
        [NameInMap("FsetId")]
        [Validation(Required=false)]
        public string FsetId { get; set; }

        /// <summary>
        /// <para>The total capacity limit of the quota. Unit: bytes.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Minimum value: 10,737,418,240 (10 GiB).</para>
        /// </description></item>
        /// <item><description><para>Increment: 1,073,741,824 (1 GiB).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, the capacity is unlimited.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10737418240</para>
        /// </summary>
        [NameInMap("SizeLimit")]
        [Validation(Required=false)]
        public long? SizeLimit { get; set; }

    }

}
