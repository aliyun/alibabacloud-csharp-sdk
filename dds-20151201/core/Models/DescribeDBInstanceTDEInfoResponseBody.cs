// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceTDEInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>实例的自定义密钥。</para>
        /// <para>目前仅以下地域支持BYOK（Bring Your Own Key，用户可以自行管理和拥有加密密钥）：</para>
        /// <list type="bullet">
        /// <item><description>华东1（杭州）</description></item>
        /// <item><description>华东2（上海）</description></item>
        /// <item><description>华北2（北京）</description></item>
        /// <item><description>华南1（深圳）</description></item>
        /// <item><description>中国（香港）</description></item>
        /// <item><description>新加坡</description></item>
        /// <item><description>马来西亚（吉隆坡）</description></item>
        /// </list>
        /// <remarks>
        /// <para>支持BYOK，用户可以管理且拥有密钥，系统将返回用户的自定义密钥；不支持BYOK，用户不可管理密钥，系统将返回字符串<c>NoActiveBYOK</c>。</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2axxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>加密算法。</para>
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
        /// <para>指定待授权角色的全局资源描述符ARN（Alibaba Cloud Resource Name）信息。</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012****:role/aliyunrdsinstanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// <para>The TDE status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enabled</b></description></item>
        /// <item><description><b>disabled</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("TDEStatus")]
        [Validation(Required=false)]
        public string TDEStatus { get; set; }

    }

}
