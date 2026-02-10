// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiBackendMatchCondition : TeaModel {
        /// <summary>
        /// <para>The key of the matching condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>color</para>
        /// </summary>
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The operator. Exact match, prefix match, and regular expressions are supported.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>equal</description></item>
        /// <item><description>regex</description></item>
        /// <item><description>prefix</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>equal</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The match type. Query and Header parameters can be matched.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Query</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The value of the matching condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gray</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
