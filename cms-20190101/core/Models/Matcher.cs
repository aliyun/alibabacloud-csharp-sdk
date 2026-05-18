// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class Matcher : TeaModel {
        /// <summary>
        /// <para>The name of the metric dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-fewrewr*****</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <para>The matching mode of the metric dimension. Only EQUALS is supported. Default value: EQUALS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EQUALS</para>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The value of the metric dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instanceId</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
