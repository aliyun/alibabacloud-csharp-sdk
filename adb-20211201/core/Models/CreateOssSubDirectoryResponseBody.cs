// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateOssSubDirectoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateOssSubDirectoryResponseBodyData Data { get; set; }
        public class CreateOssSubDirectoryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The cyclic redundancy check (CRC) value on the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ClientCRC")]
            [Validation(Required=false)]
            public long? ClientCRC { get; set; }

            /// <summary>
            /// <para>The tag of the OSS path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ETag")]
            [Validation(Required=false)]
            public string ETag { get; set; }

            /// <summary>
            /// <para>The request ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3A0DE2E0-A37B-5EE4-9136-C4C473714802</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// <para>The CRC-64 value on the OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ServerCRC")]
            [Validation(Required=false)]
            public long? ServerCRC { get; set; }

        }

        /// <summary>
        /// <para>The response code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, a <b>success</b> message is returned.</description></item>
        /// <item><description>If the request failed, an error message is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3A0DE2E0-A37B-5EE4-9136-C4C473714802</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
