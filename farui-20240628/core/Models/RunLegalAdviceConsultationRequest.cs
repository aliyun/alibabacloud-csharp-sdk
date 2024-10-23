// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunLegalAdviceConsultationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>farui</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("assistant")]
        [Validation(Required=false)]
        public RunLegalAdviceConsultationRequestAssistant Assistant { get; set; }
        public class RunLegalAdviceConsultationRequestAssistant : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>assitant_abc_123</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("metaData")]
            [Validation(Required=false)]
            public Dictionary<string, string> MetaData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>legal_advice_consult</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        [NameInMap("thread")]
        [Validation(Required=false)]
        public RunLegalAdviceConsultationRequestThread Thread { get; set; }
        public class RunLegalAdviceConsultationRequestThread : TeaModel {
            [NameInMap("messages")]
            [Validation(Required=false)]
            public List<RunLegalAdviceConsultationRequestThreadMessages> Messages { get; set; }
            public class RunLegalAdviceConsultationRequestThreadMessages : TeaModel {
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

        }

    }

}
