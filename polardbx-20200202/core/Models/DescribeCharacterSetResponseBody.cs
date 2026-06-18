// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeCharacterSetResponseBody : TeaModel {
        /// <summary>
        /// <para>The data struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCharacterSetResponseBodyData Data { get; set; }
        public class DescribeCharacterSetResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The character sets supported by the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>utf8mb4</description></item>
            /// <item><description>gbk</description></item>
            /// <item><description>latin1</description></item>
            /// <item><description>utf8.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("CharacterSet")]
            [Validation(Required=false)]
            public List<string> CharacterSet { get; set; }

            /// <summary>
            /// <para>The storage type of databases in the target instance. Currently, only polarx is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarx</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

        }

        /// <summary>
        /// <para>The response message. &quot;success&quot; is returned if the request is successful. Otherwise, an error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>709C1E40-092D-4A3D-9958-6D7438******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
