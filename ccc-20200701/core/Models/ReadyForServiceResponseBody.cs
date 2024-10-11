// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ReadyForServiceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReadyForServiceResponseBodyData Data { get; set; }
        public class ReadyForServiceResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Warm-up</para>
            /// </summary>
            [NameInMap("BreakCode")]
            [Validation(Required=false)]
            public string BreakCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ACC-YUNBS-1.0.10-****</para>
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
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>job-6538214103685****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("OutboundScenario")]
            [Validation(Required=false)]
            public bool? OutboundScenario { get; set; }

            [NameInMap("SignedSkillGroupIdList")]
            [Validation(Required=false)]
            public List<string> SignedSkillGroupIdList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>agent@ccc-test</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>READY</para>
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

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CC49060B-87ED-489A-AD3D-00E57775DBFF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
