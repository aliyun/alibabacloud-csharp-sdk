// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetDataServiceApiErrorImpactResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The summary of call exception impacts.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataServiceApiErrorImpactResponseBodyData Data { get; set; }
        public class GetDataServiceApiErrorImpactResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of APIs affected by exceptions.</para>
            /// </summary>
            [NameInMap("ErrorApiList")]
            [Validation(Required=false)]
            public List<GetDataServiceApiErrorImpactResponseBodyDataErrorApiList> ErrorApiList { get; set; }
            public class GetDataServiceApiErrorImpactResponseBodyDataErrorApiList : TeaModel {
                /// <summary>
                /// <para>The API name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ApiName")]
                [Validation(Required=false)]
                public string ApiName { get; set; }

                /// <summary>
                /// <para>The API ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2012</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public long? AppId { get; set; }

                /// <summary>
                /// <para>The number of exceptions for the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ErrorCount")]
                [Validation(Required=false)]
                public long? ErrorCount { get; set; }

            }

            /// <summary>
            /// <para>The list of apps affected by exceptions.</para>
            /// </summary>
            [NameInMap("ErrorAppList")]
            [Validation(Required=false)]
            public List<GetDataServiceApiErrorImpactResponseBodyDataErrorAppList> ErrorAppList { get; set; }
            public class GetDataServiceApiErrorImpactResponseBodyDataErrorAppList : TeaModel {
                /// <summary>
                /// <para>appId</para>
                /// 
                /// <b>Example:</b>
                /// <para>1021</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public int? AppId { get; set; }

                /// <summary>
                /// <para>appKey</para>
                /// 
                /// <b>Example:</b>
                /// <para>100211</para>
                /// </summary>
                [NameInMap("AppKey")]
                [Validation(Required=false)]
                public long? AppKey { get; set; }

                /// <summary>
                /// <para>The app name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app1</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The number of exceptions for the app.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ErrorCount")]
                [Validation(Required=false)]
                public long? ErrorCount { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
