// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CheckInstanceWebTerminalRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>wss://pai-dlc-proxy-cn-shanghai.aliyun.com/terminal/t1157703270994901/dlcmjzjt1dxbmx4h/dlcmjzjt1dxbmx4h-worker-0?Token=******</para>
        /// </summary>
        [NameInMap("CheckInfo")]
        [Validation(Required=false)]
        public string CheckInfo { get; set; }

    }

}
