// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class SetAgenticSpaceQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The AgenticSpace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentic-229oypxjgpau2****</para>
        /// </summary>
        [NameInMap("AgenticSpaceId")]
        [Validation(Required=false)]
        public string AgenticSpaceId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, and you must ensure that the value is unique among different requests.</para>
        /// <para>The client token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">Ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the modification request. A dry run checks the validity of parameters and dependencies without actually modifying the instance or incurring fees.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run. The protocol service is not modified. The system checks whether required parameters are specified, the request format is valid, and business limits and dependencies are met. If the request fails the dry run, an error is returned. If the request passes the dry run, the HTTP status code 200 is returned.</description></item>
        /// <item><description>false: performs a normal request. The protocol service is modified directly after the request passes the check. This is the default value.</description></item>
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
        /// <para>The ID of the file system.</para>
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
        /// <item><description>Step size: 1,073,741,824 (1 GiB).</description></item>
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
