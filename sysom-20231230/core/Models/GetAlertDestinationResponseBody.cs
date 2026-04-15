// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetAlertDestinationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success or Sysom.ServerError</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetAlertDestinationResponseBodyData Data { get; set; }
        public class GetAlertDestinationResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1751520976660</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>name1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;webhook&quot;:&quot;&quot;,
            ///     &quot;sec&quot;:&quot;&quot;,
            /// }</para>
            /// </summary>
            [NameInMap("params")]
            [Validation(Required=false)]
            public object Params { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>console</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingtalk</para>
            /// </summary>
            [NameInMap("target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234123412352311</para>
            /// </summary>
            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1751254826285</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SysomOpenAPIAssumeRoleException: EntityNotExist.Role The role not exists: acs:ram::xxxxx:role/aliyunserviceroleforsysom</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2D693121-C925-5154-8DF6-C09A8B369822</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
