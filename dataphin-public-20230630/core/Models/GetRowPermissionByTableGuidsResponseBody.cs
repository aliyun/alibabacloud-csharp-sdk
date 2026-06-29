// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetRowPermissionByTableGuidsResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code. A value of OK indicates that the request was successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Response data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetRowPermissionByTableGuidsResponseBodyData> Data { get; set; }
        public class GetRowPermissionByTableGuidsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Row permission description</para>
            /// 
            /// <b>Example:</b>
            /// <para>Restrict query region</para>
            /// </summary>
            [NameInMap("RowPermissionDesc")]
            [Validation(Required=false)]
            public string RowPermissionDesc { get; set; }

            /// <summary>
            /// <para>Row permission ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>300000001</para>
            /// </summary>
            [NameInMap("RowPermissionId")]
            [Validation(Required=false)]
            public string RowPermissionId { get; set; }

            /// <summary>
            /// <para>Row permission name</para>
            /// 
            /// <b>Example:</b>
            /// <para>Region</para>
            /// </summary>
            [NameInMap("RowPermissionName")]
            [Validation(Required=false)]
            public string RowPermissionName { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code of the backend response</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
