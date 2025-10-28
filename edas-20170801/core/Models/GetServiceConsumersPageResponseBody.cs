// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceConsumersPageResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code that is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The data that is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceConsumersPageResponseBodyData Data { get; set; }
        public class GetServiceConsumersPageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data array that is returned.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<GetServiceConsumersPageResponseBodyDataContent> Content { get; set; }
            public class GetServiceConsumersPageResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The name of the service consumer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k8s-lq-cartservice</para>
                /// </summary>
                [NameInMap("EdasAppName")]
                [Validation(Required=false)]
                public string EdasAppName { get; set; }

                /// <summary>
                /// <para>The ID of the service consumer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>efbda488-7b33-432f-a40d-<b><b>0047</b></b></para>
                /// </summary>
                [NameInMap("EdassAppId")]
                [Validation(Required=false)]
                public string EdassAppId { get; set; }

                /// <summary>
                /// <para>The IP address of the service consumer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.20.x.xx</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            /// <summary>
            /// <para>The number of entries to return on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public int? TotalElements { get; set; }

            /// <summary>
            /// <para>The total number of returned pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>The message that is returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
