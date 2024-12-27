// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DetectTextAnomalyResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>91AC8C98-0F36-49D2-8290-742E24DF*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the text contains anomalies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>pass: the text does not contain anomalies.</description></item>
        /// <item><description>block: the text contains anomalies.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pass</para>
        /// </summary>
        [NameInMap("Suggestion")]
        [Validation(Required=false)]
        public string Suggestion { get; set; }

    }

}
