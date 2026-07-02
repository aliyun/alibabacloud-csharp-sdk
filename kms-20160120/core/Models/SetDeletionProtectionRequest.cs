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
        /// <para>This parameter is available only when EnableDeletionProtection is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>The CMK is being used by XXX. Deletion protection is set.</para>
        /// </summary>
        [NameInMap("DeletionProtectionDescription")]
        [Validation(Required=false)]
        public string DeletionProtectionDescription { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables deletion protection.</para>
        /// </description></item>
        /// <item><description><para>false: disables deletion protection. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableDeletionProtection")]
        [Validation(Required=false)]
        public bool? EnableDeletionProtection { get; set; }

        /// <summary>
        /// <para>The ID of the key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key-hzz65f3a68554s6ms****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        [NameInMap("KmsInstanceId")]
        [Validation(Required=false)]
        public string KmsInstanceId { get; set; }

        /// <summary>
        /// <para>The ARN of the CMK for which you want to configure deletion protection.<br>
        /// You can call the <a href="https://help.aliyun.com/document_detail/28952.html">DescribeKey</a> operation to query the ARN of the CMK.<br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:kms:cn-hangzhou:123213123****:key/0225f411-b21d-46d1-be5b-93931c82****</para>
        /// </summary>
        [NameInMap("ProtectedResourceArn")]
        [Validation(Required=false)]
        public string ProtectedResourceArn { get; set; }

    }

}
