// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListModelCardsRequest : TeaModel {
        /// <summary>
        /// <para>The identifier of the model provider used to filter model cards by provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>provider-xxxxxxxx</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

    }

}
