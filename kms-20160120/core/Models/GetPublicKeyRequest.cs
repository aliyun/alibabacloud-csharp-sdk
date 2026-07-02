// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetPublicKeyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the DryRun mode.</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables the DryRun mode.</para>
        /// </description></item>
        /// <item><description><para>false (default): disables the DryRun mode.</para>
        /// </description></item>
        /// </list>
        /// <para>The DryRun mode is used to test API calls, verify your permissions on resources, and check whether the parameters are valid. If you enable the DryRun mode, KMS always returns a failed response and a failure reason. The failure reasons include the following:</para>
        /// <list type="bullet">
        /// <item><description><para>DryRunOperationError: The request would have succeeded if the DryRun parameter is not specified.</para>
        /// </description></item>
        /// <item><description><para>ValidationError: The specified parameters in the request are invalid.</para>
        /// </description></item>
        /// <item><description><para>AccessDeniedError: You are not authorized to perform the operation on the KMS resource.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// <para>The globally unique identifier of the customer master key (CMK). This parameter can also be an alias that is bound to the CMK. For more information, see <a href="https://help.aliyun.com/document_detail/68522.html">Use of aliases</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5c438b18-05be-40ad-b6c2-3be6752c****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The globally unique identifier of the key version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ab1a983-7072-4bbc-a582-584b5bd8****</para>
        /// </summary>
        [NameInMap("KeyVersionId")]
        [Validation(Required=false)]
        public string KeyVersionId { get; set; }

    }

}
