// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceTDEInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The custom key of the instance.</para>
        /// <para>Currently, only the following regions support Bring Your Own Key (BYOK), which allows you to manage and own encryption keys:</para>
        /// <list type="bullet">
        /// <item><description>China (Hangzhou)</description></item>
        /// <item><description>China (Shanghai)</description></item>
        /// <item><description>China (Beijing)</description></item>
        /// <item><description>China (Shenzhen)</description></item>
        /// <item><description>Hong Kong (China)</description></item>
        /// <item><description>Singapore</description></item>
        /// <item><description>Malaysia (Kuala Lumpur)</description></item>
        /// </list>
        /// <remarks>
        /// <para>If BYOK is supported, you can manage and own the key, and the system returns your custom key. If BYOK is not supported, you cannot manage the key, and the system returns the string <c>NoActiveBYOK</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2axxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The encryption algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aes-256-cbc</para>
        /// </summary>
        [NameInMap("EncryptorName")]
        [Validation(Required=false)]
        public string EncryptorName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F4DD0E29-361B-42F2-9301-B0048CCCE5D6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The global resource descriptor ARN (Alibaba Cloud Resource Name) of the role pending authorization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/aliyunrdsinstanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// <para>The TDE enabling status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enabled</b>: TDE is enabled.</description></item>
        /// <item><description><b>disabled</b>: TDE is disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the TDE status is disabled, the <b>RoleARN</b>, <b>EncryptionKey</b>, and <b>EncryptorName</b> parameters are not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("TDEStatus")]
        [Validation(Required=false)]
        public string TDEStatus { get; set; }

    }

}
