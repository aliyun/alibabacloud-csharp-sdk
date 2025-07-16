// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LingMou20250527.Models
{
    public class CreateChatSessionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmq-cn-9t946y43m1d</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b9be4b25c2d38c409c376ffd2372be1</para>
        /// </summary>
        [NameInMap("license")]
        [Validation(Required=false)]
        public string License { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Web | Android | iOS</para>
        /// </summary>
        [NameInMap("platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

    }

}
