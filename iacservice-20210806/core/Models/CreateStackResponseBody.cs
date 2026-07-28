// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateStackResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79284133-D4BA-56B3-954C-D538256F7EAA</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The stack ID. This is the unique identifier of the stack after it is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stack-as1d4vld898ppnqbxxxxx</para>
        /// </summary>
        [NameInMap("stackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

    }

}
