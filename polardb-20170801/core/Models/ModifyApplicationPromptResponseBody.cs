// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyApplicationPromptResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>papt-f9lajgw765f4fnrzn1</para>
        /// </summary>
        [NameInMap("PromptId")]
        [Validation(Required=false)]
        public string PromptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7E2FE3BB-C677-5FF9-9FC5-9CF364BD6BE5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
