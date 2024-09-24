// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetObjectScanEventResponseBody : TeaModel {
        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetObjectScanEventResponseBodyData Data { get; set; }
        public class GetObjectScanEventResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the alert event.</para>
            /// </summary>
            [NameInMap("Details")]
            [Validation(Required=false)]
            public List<GetObjectScanEventResponseBodyDataDetails> Details { get; set; }
            public class GetObjectScanEventResponseBodyDataDetails : TeaModel {
                /// <summary>
                /// <para>The type of the item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>html</para>
                /// </summary>
                [NameInMap("InfoType")]
                [Validation(Required=false)]
                public string InfoType { get; set; }

                /// <summary>
                /// <para>The name of the item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DownloadUrl</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The display name of the item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DownloadUrl</para>
                /// </summary>
                [NameInMap("NameDisplay")]
                [Validation(Required=false)]
                public string NameDisplay { get; set; }

                /// <summary>
                /// <para>The type of the item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>html</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value of the item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http://****</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The display value of the item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http://****</para>
                /// </summary>
                [NameInMap("ValueDisplay")]
                [Validation(Required=false)]
                public string ValueDisplay { get; set; }

            }

            /// <summary>
            /// <para>The name of the alert item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WebShell</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The name of the object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sca_2023****</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The MD5 hash value of the object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0552c44e243abdea1729d4507bce****</para>
            /// </summary>
            [NameInMap("Md5")]
            [Validation(Required=false)]
            public string Md5 { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30CBF632-109F-596F-97F2-451C8B2A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
