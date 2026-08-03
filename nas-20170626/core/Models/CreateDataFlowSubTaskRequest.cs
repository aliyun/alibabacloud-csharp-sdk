// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateDataFlowSubTaskRequest : TeaModel {
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
        /// <para>The verification condition. The specified conditions must pass verification.</para>
        /// </summary>
        [NameInMap("Condition")]
        [Validation(Required=false)]
        public CreateDataFlowSubTaskRequestCondition Condition { get; set; }
        public class CreateDataFlowSubTaskRequestCondition : TeaModel {
            /// <summary>
            /// <para>The modification time as a UNIX timestamp. Unit: ns.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1725897600000000000</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The file size. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

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
        /// <para>The data flow task ID.</para>
        /// <remarks>
        /// <para>Only data flow streaming task IDs are supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-38aa8e890f45****</para>
        /// </summary>
        [NameInMap("DataFlowTaskId")]
        [Validation(Required=false)]
        public string DataFlowTaskId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for this request.</para>
        /// <para>A dry run checks parameter validity and resource availability without actually creating the instance or incurring charges.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Sends a check request without creating the data flow. The check items include whether required parameters are specified, the request format, and business limit dependencies. If the check fails, the corresponding error is returned. If the check passes, HTTP status code 200 is returned, but DataFlowSubTaskId is empty.</description></item>
        /// <item><description>false (default): Sends a normal request and directly creates the instance after the check passes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The destination file path.
        /// Limits:</para>
        /// <list type="bullet">
        /// <item><description>The value must be 1 to 1,023 characters in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// <item><description>The value must start with a forward slash (/).</description></item>
        /// <item><description>The value must end with a file name.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/mnt/file.png</para>
        /// </summary>
        [NameInMap("DstFilePath")]
        [Validation(Required=false)]
        public string DstFilePath { get; set; }

        /// <summary>
        /// <para>The file system ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-370lx1ev9ss27o0****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The source file path.
        /// Limits:</para>
        /// <list type="bullet">
        /// <item><description>The value must be 1 to 1,023 characters in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// <item><description>The value must start with a forward slash (/).</description></item>
        /// <item><description>The value must end with a file name.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test/file.png</para>
        /// </summary>
        [NameInMap("SrcFilePath")]
        [Validation(Required=false)]
        public string SrcFilePath { get; set; }

    }

}
