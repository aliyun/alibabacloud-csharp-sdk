// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class BatchUpdateFileMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>The files whose metadata was updated.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<BatchUpdateFileMetaResponseBodyFiles> Files { get; set; }
        public class BatchUpdateFileMetaResponseBodyFiles : TeaModel {
            /// <summary>
            /// <para>The error message returned when the value of the Success parameter is false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>*error.OpError : InvalidArgument | Index KV count exceeded, should be no more than 100.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether the request was successful. Valid values:</para>
            /// <para>Enumerated values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <para>The URI of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://examplebucket/example.jpg</para>
            /// </summary>
            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5BF215E-3237-0852-B9C6-F233D44A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
