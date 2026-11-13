// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetModelGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetModelGroupResponseBodyData Data { get; set; }
        public class GetModelGroupResponseBodyData : TeaModel {
            [NameInMap("configurationDeployment")]
            [Validation(Required=false)]
            public GetModelGroupResponseBodyDataConfigurationDeployment ConfigurationDeployment { get; set; }
            public class GetModelGroupResponseBodyDataConfigurationDeployment : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>op-xxxxxxxx</para>
                /// </summary>
                [NameInMap("operationId")]
                [Validation(Required=false)]
                public string OperationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("revision")]
                [Validation(Required=false)]
                public long? Revision { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Succeeded</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>面向对话场景的模型组。</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("entitlementState")]
            [Validation(Required=false)]
            public GetModelGroupResponseBodyDataEntitlementState EntitlementState { get; set; }
            public class GetModelGroupResponseBodyDataEntitlementState : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("appliedRevision")]
                [Validation(Required=false)]
                public long? AppliedRevision { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("desiredRevision")]
                [Validation(Required=false)]
                public long? DesiredRevision { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>许可同步失败。</para>
                /// </summary>
                [NameInMap("errorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Committed</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>gw-xxxxxxxx</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            [NameInMap("modelCardIds")]
            [Validation(Required=false)]
            public List<string> ModelCardIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mg-xxxxxxxx</para>
            /// </summary>
            [NameInMap("modelGroupId")]
            [Validation(Required=false)]
            public string ModelGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>chat-group</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-05-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
