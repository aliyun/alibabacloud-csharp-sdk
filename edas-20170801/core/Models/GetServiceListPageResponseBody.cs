// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceListPageResponseBody : TeaModel {
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
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetServiceListPageResponseBodyData Data { get; set; }
        public class GetServiceListPageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data array that is returned.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<GetServiceListPageResponseBodyDataContent> Content { get; set; }
            public class GetServiceListPageResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The ID of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>efbda488-7b33-432f-<b><b>-36530047</b></b></para>
                /// </summary>
                [NameInMap("EdasAppId")]
                [Validation(Required=false)]
                public string EdasAppId { get; set; }

                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k8s-lq-cartservice</para>
                /// </summary>
                [NameInMap("EdasAppName")]
                [Validation(Required=false)]
                public string EdasAppName { get; set; }

                /// <summary>
                /// <para>The service group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DUBBO</para>
                /// </summary>
                [NameInMap("Group")]
                [Validation(Required=false)]
                public string Group { get; set; }

                /// <summary>
                /// <para>The number of instances.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InstanceNum")]
                [Validation(Required=false)]
                public int? InstanceNum { get; set; }

                /// <summary>
                /// <para>The type of the service registry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("RegisterType")]
                [Validation(Required=false)]
                public string RegisterType { get; set; }

                /// <summary>
                /// <para>The ID of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx</para>
                /// </summary>
                [NameInMap("ServiceId")]
                [Validation(Required=false)]
                public string ServiceId { get; set; }

                /// <summary>
                /// <para>The name of the service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>com.alibabacloud.hipstershop.CartService</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The total number of returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
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
