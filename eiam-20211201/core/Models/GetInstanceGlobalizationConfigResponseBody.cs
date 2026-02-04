// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetInstanceGlobalizationConfigResponseBody : TeaModel {
        [NameInMap("GlobalizationConfig")]
        [Validation(Required=false)]
        public GetInstanceGlobalizationConfigResponseBodyGlobalizationConfig GlobalizationConfig { get; set; }
        public class GetInstanceGlobalizationConfigResponseBodyGlobalizationConfig : TeaModel {
            /// <summary>
            /// <para>语言</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh-Hans-CN</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>时区</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
