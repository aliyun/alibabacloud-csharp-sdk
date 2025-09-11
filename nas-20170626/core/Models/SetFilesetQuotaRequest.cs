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
        /// <para>Specifies whether to perform a dry run. The dry run checks parameter validity and prerequisites. The dry run does not delete the specified quota or incur fees.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run. The system checks the required parameters, request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the HTTP status code 200 is returned.</description></item>
        /// <item><description>false (default): performs a dry run and sends the request. If the request passes the dry run, the quota is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The number of files of the quota. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Minimum value: 10,000.</description></item>
        /// <item><description>Maximum value: 10,000,000,000.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, the number of files is unlimited.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("FileCountLimit")]
        [Validation(Required=false)]
        public long? FileCountLimit { get; set; }

        /// <summary>
        /// <para>The ID of the CPFS for LINGJUN file system. The IDs of CPFS for LINGJUN file systems must start with <c>bmcpfs-</c>. Example: bmcpfs-290w65p03ok64ya\<em>\</em>\<em>\</em>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-290w65p03ok64ya****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The fileset ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fset-1902718ea0ae****</para>
        /// </summary>
        [NameInMap("FsetId")]
        [Validation(Required=false)]
        public string FsetId { get; set; }

        /// <summary>
        /// <para>The total capacity of the quota. Unit: bytes.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Minimum value: 10,737,418,240 (10 GiB).</description></item>
        /// <item><description>Step size: 1,073,741,824 (1 GiB).</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, the capacity is unlimited.</para>
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
