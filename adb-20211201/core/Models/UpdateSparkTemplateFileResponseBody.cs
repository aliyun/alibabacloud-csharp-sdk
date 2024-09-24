// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class UpdateSparkTemplateFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The update result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateSparkTemplateFileResponseBodyData Data { get; set; }
        public class UpdateSparkTemplateFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the application template is updated.</para>
            /// <list type="bullet">
            /// <item><description><b>True</b></description></item>
            /// <item><description><b>False</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Succeeded")]
            [Validation(Required=false)]
            public bool? Succeeded { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C3A9594F-1D40-4472-A96C-8FB8AA20D38C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
