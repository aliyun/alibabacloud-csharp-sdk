// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FaRui20240628.Models
{
    public class RunContractRuleGenerationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>farui</para>
        /// </summary>
        [NameInMap("appId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("assistant")]
        [Validation(Required=false)]
        public RunContractRuleGenerationRequestAssistant Assistant { get; set; }
        public class RunContractRuleGenerationRequestAssistant : TeaModel {
            [NameInMap("metaData")]
            [Validation(Required=false)]
            public RunContractRuleGenerationRequestAssistantMetaData MetaData { get; set; }
            public class RunContractRuleGenerationRequestAssistantMetaData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>9a6b1ba60d9944249363ec3cc1529b7b</para>
                /// </summary>
                [NameInMap("fileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("position")]
                [Validation(Required=false)]
                public string Position { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>contract_examime</para>
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

    }

}
