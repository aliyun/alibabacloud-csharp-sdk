// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class SetDeletionProtectionRequest : TeaModel {
        /// <summary>
        /// <para>The description of deletion protection.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when you set the EnableDeletionProtection parameter to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>This key is being used by XXX service. You are protected from deletion.</para>
        /// </summary>
        [NameInMap("DeletionProtectionDescription")]
        [Validation(Required=false)]
        public string DeletionProtectionDescription { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables deletion protection.</description></item>
        /// <item><description>false: disables deletion protection.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableDeletionProtection")]
        [Validation(Required=false)]
        public bool? EnableDeletionProtection { get; set; }

        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The ARN of the CMK for which you want to set deletion protection.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the CMK ARN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:kms:cn-hangzhou:123213123****:key/0225f411-b21d-46d1-be5b-93931c82****</para>
        /// </summary>
        [NameInMap("ProtectedResourceArn")]
        [Validation(Required=false)]
        public string ProtectedResourceArn { get; set; }

    }

}
