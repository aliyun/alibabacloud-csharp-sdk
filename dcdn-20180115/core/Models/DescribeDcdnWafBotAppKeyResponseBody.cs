// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafBotAppKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The SDK authentication key for the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>examp1eapp_key_xxxiuMWTX4Gw</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2542B96-B535-5BF9-8EEE-1CF11B20CCA8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
