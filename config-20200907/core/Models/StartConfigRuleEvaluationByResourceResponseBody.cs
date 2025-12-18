// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class StartConfigRuleEvaluationByResourceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cr-2da35180a8d1008e****</para>
        /// </summary>
        [NameInMap("ConfigRuleId")]
        [Validation(Required=false)]
        public string ConfigRuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A7A0FFF8-0B44-40C6-8BBF-3A185EFDF3F7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
