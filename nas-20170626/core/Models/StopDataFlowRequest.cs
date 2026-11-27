// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class StopDataFlowRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the client token that ensures request idempotence. Generate a parameter value from your client to ensure that this parameter value is unique across different requests.</para>
        /// <para>The ClientToken parameter supports only ASCII characters and cannot exceed 64 characters. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
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
        /// <para>The data flow ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>df-194433a5be31****</para>
        /// </summary>
        [NameInMap("DataFlowId")]
        [Validation(Required=false)]
        public string DataFlowId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on this creation request.</para>
        /// <para>A dry run checks the validity of parameters and inventory, but does not actually create an instance or incur fees.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Sends a check request. No instance is created. Checks include whether required parameters are specified, the request format, business limits, and NAS inventory. If the check fails, the corresponding error is returned. If the check succeeds, the 200 HTTP status code is returned, but FileSystemId is empty.</description></item>
        /// <item><description>false (default): Sends a normal request and directly creates the instance after the check succeeds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

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

    }

}
