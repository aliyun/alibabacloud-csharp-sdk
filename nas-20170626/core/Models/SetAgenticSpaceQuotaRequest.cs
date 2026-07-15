// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class SetAgenticSpaceQuotaRequest : TeaModel {
        /// <summary>
        /// <para>AgenticSpace Id。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentic-229oypxjgpau2****</para>
        /// </summary>
        [NameInMap("AgenticSpaceId")]
        [Validation(Required=false)]
        public string AgenticSpaceId { get; set; }

        /// <summary>
        /// <para>Ensures the idempotency of the request. Generate a unique parameter value from your client to ensure that the value is unique across different requests.</para>
        /// <para>ClientToken supports only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotency</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may differ for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for this request. A dry run checks parameter validity and dependencies without actually modifying the instance or incurring charges.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Sends a dry run request without modifying the protocol service. The check items include required parameters, request format, and business dependency conditions. If the check fails, the corresponding error is returned. If the check passes, HTTP status code 200 is returned.</description></item>
        /// <item><description>false (default): Sends a normal request. After the check passes, the protocol service is directly modified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The file count limit for the quota. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Minimum value: 10,000.</para>
        /// </description></item>
        /// <item><description><para>Maximum value: 100,000,000.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("FileCountLimit")]
        [Validation(Required=false)]
        public long? FileCountLimit { get; set; }

        /// <summary>
        /// <para>The file system ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ca404****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The total capacity limit for the quota. Unit: bytes.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Minimum value: 10,737,418,240 (10 GiB).</description></item>
        /// <item><description>Maximum value: 1,099,511,627,776,000 (1,024,000 GiB).</description></item>
        /// <item><description>Step: 1,073,741,824 (1 GiB).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10737418240</para>
        /// </summary>
        [NameInMap("SizeLimit")]
        [Validation(Required=false)]
        public long? SizeLimit { get; set; }

    }

}
