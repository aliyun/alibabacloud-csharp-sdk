// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetDataServiceAppMembersResponseBody : TeaModel {
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
        /// <para>The member list of the data service application.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDataServiceAppMembersResponseBodyData Data { get; set; }
        public class GetDataServiceAppMembersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The application member list.</para>
            /// </summary>
            [NameInMap("MemberList")]
            [Validation(Required=false)]
            public List<GetDataServiceAppMembersResponseBodyDataMemberList> MemberList { get; set; }
            public class GetDataServiceAppMembersResponseBodyDataMemberList : TeaModel {
                /// <summary>
                /// <para>The authorization expiration time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-12-12</para>
                /// </summary>
                [NameInMap("EffectiveEnd")]
                [Validation(Required=false)]
                public string EffectiveEnd { get; set; }

                /// <summary>
                /// <para>The role of the user. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>general: regular member.</description></item>
                /// <item><description>owner: application owner.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200000245</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

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
        /// <para>The error message returned from the backend.</para>
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
