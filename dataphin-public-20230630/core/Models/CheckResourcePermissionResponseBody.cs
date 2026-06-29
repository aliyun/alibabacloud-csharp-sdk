// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class CheckResourcePermissionResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code. OK indicates a successful request</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code returned by the backend</para>
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
        /// <para>Resource permission list</para>
        /// </summary>
        [NameInMap("ResourcePermissionList")]
        [Validation(Required=false)]
        public List<CheckResourcePermissionResponseBodyResourcePermissionList> ResourcePermissionList { get; set; }
        public class CheckResourcePermissionResponseBodyResourcePermissionList : TeaModel {
            /// <summary>
            /// <para>Indicates whether the user has the permission on the specified resource</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasPermission")]
            [Validation(Required=false)]
            public bool? HasPermission { get; set; }

            /// <summary>
            /// <para>Resource ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>hadoop.300000806.data_distill.behavior_gameinfor_01</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
