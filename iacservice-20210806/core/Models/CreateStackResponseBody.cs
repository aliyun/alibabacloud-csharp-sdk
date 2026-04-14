// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateStackResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>79284133-D4BA-56B3-954C-D538256F7EAA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>stack-as1d4vld898ppnqbxxxxx</para>
        /// </summary>
        [NameInMap("stackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
