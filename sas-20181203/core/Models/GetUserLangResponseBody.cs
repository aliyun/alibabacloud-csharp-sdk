// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetUserLangResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23AD0BD2-8771-5647-819E-6BA51E21****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The language settings.</para>
        /// </summary>
        [NameInMap("SasUserLang")]
        [Validation(Required=false)]
        public GetUserLangResponseBodySasUserLang SasUserLang { get; set; }
        public class GetUserLangResponseBodySasUserLang : TeaModel {
            /// <summary>
            /// <para>The language specified for log analysis. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>zh: Chinese</description></item>
            /// <item><description>en: English</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

        }

    }

}
