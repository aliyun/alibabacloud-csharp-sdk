// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appflow20230904.Models
{
    public class ListUserAuthConfigsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAVY3rYiv9VoUJQSiCitgjgRBp055u+7M/ZFoi7I0NZHJj8bgHiGAwZWnCMJPepC+WQbLSjoLewJIqkMQqvaJO7M=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>35A48818-81F2-506C-891C-2296BE8DD667</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("UserAuthConfigs")]
        [Validation(Required=false)]
        public List<ListUserAuthConfigsResponseBodyUserAuthConfigs> UserAuthConfigs { get; set; }
        public class ListUserAuthConfigsResponseBodyUserAuthConfigs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>uac-xxxxxxxx</para>
            /// </summary>
            [NameInMap("AuthConfigId")]
            [Validation(Required=false)]
            public string AuthConfigId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("AuthConfigName")]
            [Validation(Required=false)]
            public string AuthConfigName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ApiKey</para>
            /// </summary>
            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>connector-xxxxxxxxx</para>
            /// </summary>
            [NameInMap("ConnectorId")]
            [Validation(Required=false)]
            public string ConnectorId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ConnectorVersion")]
            [Validation(Required=false)]
            public string ConnectorVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FlowCount")]
            [Validation(Required=false)]
            public int? FlowCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-04-01 14:22:33</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-04-01 14:22:33</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

        }

    }

}
