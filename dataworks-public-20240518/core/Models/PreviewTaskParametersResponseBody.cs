// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class PreviewTaskParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>The parameter preview results for each cycle.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<PreviewTaskParametersResponseBodyItems> Items { get; set; }
        public class PreviewTaskParametersResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The business date of the cycle. The value is a 13-digit UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1792425600000</para>
            /// </summary>
            [NameInMap("Bizdate")]
            [Validation(Required=false)]
            public long? Bizdate { get; set; }

            /// <summary>
            /// <para>The error message returned when the parsing for the cycle fails. This parameter is returned when Success is false and is not returned when Success is true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Failed to parse scheduling parameters. Check the parameter settings.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The complete script parameter string parsed for the cycle. Multiple parameters are separated by spaces. This parameter is returned when Success is true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>para1=20261020 para2=00</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// <para>Specifies whether the scheduling parameters for the cycle are parsed successfully. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The parsing is successful.</description></item>
            /// <item><description>false: The parsing fails.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <para>The simulated scheduled trigger time. The value is a 13-digit UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1792512000000</para>
            /// </summary>
            [NameInMap("TriggerTime")]
            [Validation(Required=false)]
            public long? TriggerTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22C97E95-F023-56B5-8852-B1A77A17XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
