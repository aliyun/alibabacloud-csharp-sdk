// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListAgentsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAgentsResponseBodyData Data { get; set; }
        public class ListAgentsResponseBodyData : TeaModel {
            [NameInMap("Agents")]
            [Validation(Required=false)]
            public List<Agent> Agents { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>uat-agent</para>
            /// </summary>
            [NameInMap("FirstId")]
            [Validation(Required=false)]
            public string FirstId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public string HasMore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>last-agent</para>
            /// </summary>
            [NameInMap("LastId")]
            [Validation(Required=false)]
            public string LastId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Failed to list agents</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7DA60DED-CD36-5837-B848-C01A23D2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
