// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetDataServiceAuthorizedAppsByGroupIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of API groups.</para>
        /// </summary>
        [NameInMap("AppInfoList")]
        [Validation(Required=false)]
        public List<GetDataServiceAuthorizedAppsByGroupIdResponseBodyAppInfoList> AppInfoList { get; set; }
        public class GetDataServiceAuthorizedAppsByGroupIdResponseBodyAppInfoList : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The application key.</para>
            /// <remarks>
            /// <para>Notice: Deprecated. Use AppKeyStr instead.</notice>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("AppKey")]
            [Validation(Required=false)]
            [Obsolete]
            public long? AppKey { get; set; }

            /// <summary>
            /// <para>The application key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app12345</para>
            /// </summary>
            [NameInMap("AppKeyStr")]
            [Validation(Required=false)]
            public string AppKeyStr { get; set; }

            /// <summary>
            /// <para>AppId</para>
            /// 
            /// <b>Example:</b>
            /// <para>1021</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The app name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

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
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backend exception.</para>
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
