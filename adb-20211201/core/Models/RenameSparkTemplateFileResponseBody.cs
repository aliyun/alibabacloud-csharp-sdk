// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class RenameSparkTemplateFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RenameSparkTemplateFileResponseBodyData Data { get; set; }
        public class RenameSparkTemplateFileResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the request was successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>True</description></item>
            /// <item><description>False</description></item>
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
        /// <para>16D332C4-ACEB-526A-9B53-2B708FED594A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
