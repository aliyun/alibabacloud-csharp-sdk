// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ChangeVisibilityResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ChangeVisibilityResponseBodyData Data { get; set; }
        public class ChangeVisibilityResponseBodyData : TeaModel {
            [NameInMap("BreakCode")]
            [Validation(Required=false)]
            public string BreakCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Yealink SIP-T23G 44.84.203.6</para>
            /// </summary>
            [NameInMap("DeviceId")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8001****</para>
            /// </summary>
            [NameInMap("Extension")]
            [Validation(Required=false)]
            public string Extension { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>szpczf</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>job-330557290544431104</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("OutboundScenario")]
            [Validation(Required=false)]
            public bool? OutboundScenario { get; set; }

            [NameInMap("SignedSkillGroupIdList")]
            [Validation(Required=false)]
            public List<string> SignedSkillGroupIdList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sam@szpczf</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Ready</para>
            /// </summary>
            [NameInMap("UserState")]
            [Validation(Required=false)]
            public string UserState { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ON_SITE</para>
            /// </summary>
            [NameInMap("WorkMode")]
            [Validation(Required=false)]
            public string WorkMode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Internal service issue. Detail:.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>24BE19E8-BF7D-4992-A35E-15EBA874F2E5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
