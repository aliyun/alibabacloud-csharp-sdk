// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateApplicationPromptResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>papt-f9lajgw765f4fnrzn1</para>
        /// </summary>
        [NameInMap("PromptId")]
        [Validation(Required=false)]
        public string PromptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6BD9CDE4-5E7B-4BF3-9BB8-83C73E******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
