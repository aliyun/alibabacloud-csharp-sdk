// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeMixStreamListResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the stream mixing tasks.</para>
        /// </summary>
        [NameInMap("MixStreamList")]
        [Validation(Required=false)]
        public List<DescribeMixStreamListResponseBodyMixStreamList> MixStreamList { get; set; }
        public class DescribeMixStreamListResponseBodyMixStreamList : TeaModel {
            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveApp****</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The main streaming domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The time when the stream mixing task was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-17T08:39:14Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the stream mixing task was modified. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-09-17T08:39:15Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The number of input streams.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InputStreamNumber")]
            [Validation(Required=false)]
            public int? InputStreamNumber { get; set; }

            /// <summary>
            /// <para>The ID of the layout.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USERDEFINED</para>
            /// </summary>
            [NameInMap("LayoutId")]
            [Validation(Required=false)]
            public string LayoutId { get; set; }

            /// <summary>
            /// <para>The stream mixing template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lp_ld</para>
            /// </summary>
            [NameInMap("MixStreamTemplate")]
            [Validation(Required=false)]
            public string MixStreamTemplate { get; set; }

            /// <summary>
            /// <para>The ID of the stream mixing task. You can specify this parameter in a request to delete the steam mixing task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aaf9a50f-c460-3a9b-f180-38dd8f05****</para>
            /// </summary>
            [NameInMap("MixstreamId")]
            [Validation(Required=false)]
            public string MixstreamId { get; set; }

            /// <summary>
            /// <para>The name of the output stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>liveStream****</para>
            /// </summary>
            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC1E78D3-FA8B-4457-DEE2-6093E1232254</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
