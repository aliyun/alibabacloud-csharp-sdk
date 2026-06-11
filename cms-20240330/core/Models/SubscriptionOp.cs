// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SubscriptionOp : TeaModel {
        [NameInMap("op")]
        [Validation(Required=false)]
        public string Op { get; set; }

        /// <summary>
        /// <para>create/update 必填</para>
        /// </summary>
        [NameInMap("payload")]
        [Validation(Required=false)]
        public SubscriptionForModify Payload { get; set; }

        /// <summary>
        /// <para>update/remove 必填</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
