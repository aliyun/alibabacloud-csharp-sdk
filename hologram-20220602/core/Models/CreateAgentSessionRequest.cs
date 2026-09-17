// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220602.Models
{
    public class CreateAgentSessionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2072736942627512345</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public CreateAgentSessionRequestParams Params { get; set; }
        public class CreateAgentSessionRequestParams : TeaModel {
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public CreateAgentSessionRequestParamsMeta Meta { get; set; }
            public class CreateAgentSessionRequestParamsMeta : TeaModel {
                [NameInMap("Agent")]
                [Validation(Required=false)]
                public CreateAgentSessionRequestParamsMetaAgent Agent { get; set; }
                public class CreateAgentSessionRequestParamsMetaAgent : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hologres</para>
                    /// </summary>
                    [NameInMap("AgentName")]
                    [Validation(Required=false)]
                    public string AgentName { get; set; }

                }

                [NameInMap("Config")]
                [Validation(Required=false)]
                public CreateAgentSessionRequestParamsMetaConfig Config { get; set; }
                public class CreateAgentSessionRequestParamsMetaConfig : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CHAT_HOLOGRES</para>
                    /// </summary>
                    [NameInMap("SessionSource")]
                    [Validation(Required=false)]
                    public string SessionSource { get; set; }

                    [NameInMap("SessionTags")]
                    [Validation(Required=false)]
                    public List<CreateAgentSessionRequestParamsMetaConfigSessionTags> SessionTags { get; set; }
                    public class CreateAgentSessionRequestParamsMetaConfigSessionTags : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>holo</para>
                        /// </summary>
                        [NameInMap("SessionTagCode")]
                        [Validation(Required=false)]
                        public string SessionTagCode { get; set; }

                    }

                }

                [NameInMap("InitialConfigOptions")]
                [Validation(Required=false)]
                public CreateAgentSessionRequestParamsMetaInitialConfigOptions InitialConfigOptions { get; set; }
                public class CreateAgentSessionRequestParamsMetaInitialConfigOptions : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cli</para>
                    /// </summary>
                    [NameInMap("ExecutionLane")]
                    [Validation(Required=false)]
                    public string ExecutionLane { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>yolo</para>
                    /// </summary>
                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>rg-acfmvqsnvkfr2sa</para>
                    /// </summary>
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>skill-name-1,skill-name2,skill-name-3</para>
                    /// </summary>
                    [NameInMap("Skills")]
                    [Validation(Required=false)]
                    public string Skills { get; set; }

                }

            }

        }

    }

}
