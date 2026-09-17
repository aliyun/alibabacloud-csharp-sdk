// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SubscriptionOp : TeaModel {
        /// <summary>
        /// <para>The operation type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>create</para>
        /// </summary>
        [NameInMap("op")]
        [Validation(Required=false)]
        public string Op { get; set; }

        /// <summary>
        /// <para>Required for create and update operations.</para>
        /// </summary>
        [NameInMap("payload")]
        [Validation(Required=false)]
        public SubscriptionForModify Payload { get; set; }

        /// <summary>
        /// <para>Required for update and remove operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7076c75c-c804-461e-975f-c6f9ed5af745</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
