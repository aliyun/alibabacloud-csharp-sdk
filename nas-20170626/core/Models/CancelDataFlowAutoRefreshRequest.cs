// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CancelDataFlowAutoRefreshRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can generate the value on your client and ensure that the value is unique across different requests.</para>
        /// <para>The client token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
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
        /// <para>Specifies whether to perform a dry run on this request.</para>
        /// <para>A dry run checks parameter validity and resource availability. It does not actually perform the operation or incur fees.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run without performing the operation. The system checks whether required parameters are specified, whether the request format is valid, and whether business limits are met. If the request fails the dry run, an error is returned. If the request passes the dry run, HTTP status code 200 is returned, but DataFlowId is empty.</description></item>
        /// <item><description>false (default): sends a regular request. If the request passes the check, the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

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
        /// <para>The directory for which you want to cancel the auto-update configuration.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The value must be 2 to 1,024 characters in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// <item><description>The value must start and end with a forward slash (/).</description></item>
        /// </list>
        /// <remarks>
        /// <para>The directory must already exist in the CPFS file system and must be located in a Fileset for which the data flow feature is enabled.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/prefix1/prefix2/</para>
        /// </summary>
        [NameInMap("RefreshPath")]
        [Validation(Required=false)]
        public string RefreshPath { get; set; }

    }

}
