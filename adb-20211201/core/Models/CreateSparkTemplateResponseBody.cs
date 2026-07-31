// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateSparkTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of creating the application template.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateSparkTemplateResponseBodyData Data { get; set; }
        public class CreateSparkTemplateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the creation is successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>True</b>: Successful.</description></item>
            /// <item><description><b>False</b>: Failed.</description></item>
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
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
