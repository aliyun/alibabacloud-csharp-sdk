// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CioMarketPop20250709.Models
{
    public class PushEveryOneSellMsgRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;1234567&quot;]</para>
        /// </summary>
        [NameInMap("DingIdList")]
        [Validation(Required=false)]
        public List<string> DingIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>推送内容</para>
        /// </summary>
        [NameInMap("PushMsg")]
        [Validation(Required=false)]
        public string PushMsg { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PushType")]
        [Validation(Required=false)]
        public string PushType { get; set; }

    }

}
