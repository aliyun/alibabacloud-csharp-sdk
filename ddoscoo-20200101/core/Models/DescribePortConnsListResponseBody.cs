// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribePortConnsListResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the connections established over the port.</para>
        /// </summary>
        [NameInMap("ConnsList")]
        [Validation(Required=false)]
        public List<DescribePortConnsListResponseBodyConnsList> ConnsList { get; set; }
        public class DescribePortConnsListResponseBodyConnsList : TeaModel {
            /// <summary>
            /// <para>The number of active connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ActConns")]
            [Validation(Required=false)]
            public long? ActConns { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is in internal preview. Do not use this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("Conns")]
            [Validation(Required=false)]
            public long? Conns { get; set; }

            /// <summary>
            /// <para>The number of new connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Cps")]
            [Validation(Required=false)]
            public long? Cps { get; set; }

            /// <summary>
            /// <para>The number of inactive connections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("InActConns")]
            [Validation(Required=false)]
            public long? InActConns { get; set; }

            /// <summary>
            /// <para>The index number of the returned data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16506</para>
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6D48AED0-41DB-5D9B-B484-3B6AAD312AD1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
