// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_push20220225.Models
{
    public class Aps : TeaModel {
        [NameInMap("alert")]
        [Validation(Required=false)]
        public Alert Alert { get; set; }

        [NameInMap("attributes")]
        [Validation(Required=false)]
        public string Attributes { get; set; }

        [NameInMap("attributesType")]
        [Validation(Required=false)]
        public string AttributesType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>+1(自增)，-1(自减)，4(设置数字)</para>
        /// </summary>
        [NameInMap("badge")]
        [Validation(Required=false)]
        public string Badge { get; set; }

        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("contentAvailable")]
        [Validation(Required=false)]
        public int? ContentAvailable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{                  &quot;status&quot;: &quot;shippingbox.fill&quot;                 }</para>
        /// </summary>
        [NameInMap("contentState")]
        [Validation(Required=false)]
        public string ContentState { get; set; }

        [NameInMap("dismissalDate")]
        [Validation(Required=false)]
        public int? DismissalDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>创建:start , 更新:update,结束:end</para>
        /// </summary>
        [NameInMap("event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        [NameInMap("interruptionLevel")]
        [Validation(Required=false)]
        public string InterruptionLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("mutableContent")]
        [Validation(Required=false)]
        public int? MutableContent { get; set; }

        [NameInMap("sound")]
        [Validation(Required=false)]
        public string Sound { get; set; }

        [NameInMap("threadID")]
        [Validation(Required=false)]
        public string ThreadID { get; set; }

        [NameInMap("timestamp")]
        [Validation(Required=false)]
        public int? Timestamp { get; set; }

    }

}
