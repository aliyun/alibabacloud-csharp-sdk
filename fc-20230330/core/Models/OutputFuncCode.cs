// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class OutputFuncCode : TeaModel {
        /// <summary>
        /// <para>The CRC-64 value of the function code package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("checksum")]
        [Validation(Required=false)]
        public string Checksum { get; set; }

        /// <summary>
        /// <para>The URL of the function code package.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://func-code.oss-cn-shanghai.aliyuncs.com/1a2b3c4d5e6f">http://func-code.oss-cn-shanghai.aliyuncs.com/1a2b3c4d5e6f</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
