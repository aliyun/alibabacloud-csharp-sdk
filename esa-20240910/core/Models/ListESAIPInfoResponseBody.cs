// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListESAIPInfoResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<ListESAIPInfoResponseBodyContent> Content { get; set; }
        public class ListESAIPInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CdnIp")]
            [Validation(Required=false)]
            public string CdnIp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>27.129.167.239</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
