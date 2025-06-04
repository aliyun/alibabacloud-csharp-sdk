// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The encryption settings. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PlainText</description></item>
        /// <item><description>Secret</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PlainText</para>
        /// </summary>
        [NameInMap("EncryptOption")]
        [Validation(Required=false)]
        public string EncryptOption { get; set; }

    }

}
