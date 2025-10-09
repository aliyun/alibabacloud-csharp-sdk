// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListESAIPInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The objects that are returned.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<ListESAIPInfoResponseBodyContent> Content { get; set; }
        public class ListESAIPInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>Whether the IP address in the parameter belongs to ESA POPs.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CdnIp")]
            [Validation(Required=false)]
            public string CdnIp { get; set; }

            /// <summary>
            /// <para>The IP addresses.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27.129.167.239</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// <para>Example D03F9502-6653-127C-8A5F-0647197\<em>\</em>\<em>\</em>\*</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
