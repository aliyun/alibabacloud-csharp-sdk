// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateDataFlowSubTaskRequest : TeaModel {
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
        /// <para>The check conditions. The check must be passed after the following conditions are specified.</para>
        /// </summary>
        [NameInMap("Condition")]
        [Validation(Required=false)]
        public CreateDataFlowSubTaskRequestCondition Condition { get; set; }
        public class CreateDataFlowSubTaskRequestCondition : TeaModel {
            /// <summary>
            /// <para>The modification time. The value must be a UNIX timestamp. Unit: ns.</para>
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
        /// <para>The ID of the data flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>df-194433a5be31****</para>
        /// </summary>
        [NameInMap("DataFlowId")]
        [Validation(Required=false)]
        public string DataFlowId { get; set; }

        /// <summary>
        /// <para>The ID of the data flow task.</para>
        /// <remarks>
        /// <para> Only the IDs of data streaming tasks are supported.</para>
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
        /// <para>Specifies whether to perform a dry run.</para>
        /// <para>During the dry run, the system checks whether the request parameters are valid and whether the requested resources are available. During the dry run, no data streaming subtask is created and no fee is incurred.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run. The system checks the required parameters, request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the HTTP status code 200 is returned. No value is returned for the DataFlowSubTaskId parameter.</description></item>
        /// <item><description>false (default): performs a dry run and sends the request. If the request passes the dry run, a data streaming subtask is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The path of the destination file. Limits:</para>
        /// <list type="bullet">
        /// <item><description>The path must be 1 to 1,023 characters in length.</description></item>
        /// <item><description>The path must be encoded in UTF-8.</description></item>
        /// <item><description>The path must start with a forward slash (/).</description></item>
        /// <item><description>The path must end with the file name.</description></item>
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
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-370lx1ev9ss27o0****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The path of the source file. Limits:</para>
        /// <list type="bullet">
        /// <item><description>The path must be 1 to 1,023 characters in length.</description></item>
        /// <item><description>The path must be encoded in UTF-8.</description></item>
        /// <item><description>The path must start with a forward slash (/).</description></item>
        /// <item><description>The path must end with the file name.</description></item>
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
