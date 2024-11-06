// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeHighlightInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The data model of the highlighted data.</para>
        /// </summary>
        [NameInMap("DataModule")]
        [Validation(Required=false)]
        public List<DescribeHighlightInfoResponseBodyDataModule> DataModule { get; set; }
        public class DescribeHighlightInfoResponseBodyDataModule : TeaModel {
            /// <summary>
            /// <para>The highlighted data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;data:image/php;base64\&quot;]</para>
            /// </summary>
            [NameInMap("Hit")]
            [Validation(Required=false)]
            public string Hit { get; set; }

            /// <summary>
            /// <para>The type of the highlighted data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>URL</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The complete data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data:image/php;base64,PD9waHAXXXXXXanVzdHR0dHXXXXXB0ZXN0Ijs/Pg==</para>
            /// </summary>
            [NameInMap("Raw")]
            [Validation(Required=false)]
            public string Raw { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
