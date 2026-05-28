// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class EncryptConf : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable data encryption. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The encryption algorithm. Valid values: default and sm4. If enable is set to true, you must configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("encrypt_type")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        /// <summary>
        /// <para>Optional. If you configure this parameter, the bring-your-own-key (BYOK) key is used. If you do not configure this parameter, the service key of Simple Log Service is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{    &quot;cmk_key_id&quot; : &quot;f5136b95-2420-ab31-xxxxxxxxx&quot;    &quot;arn&quot; :  &quot;acs:ram::13234:role/logsource&quot;    &quot;region_id&quot; : &quot;cn-hangzhou&quot;  }</para>
        /// </summary>
        [NameInMap("user_cmk_info")]
        [Validation(Required=false)]
        public EncryptUserCmkConf UserCmkInfo { get; set; }

    }

}
