// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class AiTransformField : TeaModel {
        /// <summary>
        /// <para>The value form. Currently uses JSONPATH.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JSONPATH</para>
        /// </summary>
        [NameInMap("Form")]
        [Validation(Required=false)]
        public string Form { get; set; }

        /// <summary>
        /// <para>The JSONPath expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>$.data.message</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
