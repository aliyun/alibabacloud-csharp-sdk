// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DeleteSparkTemplateFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The deletion result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteSparkTemplateFileResponseBodyData Data { get; set; }
        public class DeleteSparkTemplateFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the template file is deleted. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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
