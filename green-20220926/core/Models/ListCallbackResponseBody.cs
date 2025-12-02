// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ListCallbackResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCallbackResponseBodyData> Data { get; set; }
        public class ListCallbackResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Encryption algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHA256</para>
            /// </summary>
            [NameInMap("CryptType")]
            [Validation(Required=false)]
            public string CryptType { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-03 15:20:14</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>Modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-06-03 15:20:14</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Primary key ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11234</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>回调通知</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Result scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>Seed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cbupVnpBjkgjFxfINMHKkrHS-1zZPUm</para>
            /// </summary>
            [NameInMap("Seed")]
            [Validation(Required=false)]
            public string Seed { get; set; }

            /// <summary>
            /// <para>UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16537*****831937</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// <para>Callback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://console.aliyun.com/">https://console.aliyun.com/</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>Backend-assigned ID, used to uniquely identify a request. Can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
