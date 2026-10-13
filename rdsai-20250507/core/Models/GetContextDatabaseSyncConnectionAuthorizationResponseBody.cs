// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class GetContextDatabaseSyncConnectionAuthorizationResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetContextDatabaseSyncConnectionAuthorizationResponseBodyData Data { get; set; }
        public class GetContextDatabaseSyncConnectionAuthorizationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The authorization method. Valid values: app, pasted-url, static-secret, and none.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app</para>
            /// </summary>
            [NameInMap("AuthKind")]
            [Validation(Required=false)]
            public string AuthKind { get; set; }

            /// <summary>
            /// <para>The authorization status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ready</para>
            /// </summary>
            [NameInMap("AuthState")]
            [Validation(Required=false)]
            public string AuthState { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>R&amp;D team DingTalk data source</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The connection ID, which is a system-generated UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>550e8400-e29b-41d4-a716-446655440000</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The plugin ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dingtalk</para>
            /// </summary>
            [NameInMap("PluginId")]
            [Validation(Required=false)]
            public string PluginId { get; set; }

            /// <summary>
            /// <para>The remediation suggestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Re-authorize the data source</para>
            /// </summary>
            [NameInMap("Remediation")]
            [Validation(Required=false)]
            public string Remediation { get; set; }

            /// <summary>
            /// <para>The authorization scope report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ScopeReport")]
            [Validation(Required=false)]
            public Dictionary<string, object> ScopeReport { get; set; }

            /// <summary>
            /// <para>The credential fingerprint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sha256:4b3b7b2e5f6a1c9d8e0f1234567890abcdef1234567890abcdef1234567890ab</para>
            /// </summary>
            [NameInMap("SecretFingerprint")]
            [Validation(Required=false)]
            public string SecretFingerprint { get; set; }

            /// <summary>
            /// <para>The credential update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("SecretUpdatedAt")]
            [Validation(Required=false)]
            public string SecretUpdatedAt { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The verification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-23T10:00:00+08:00</para>
            /// </summary>
            [NameInMap("VerifiedAt")]
            [Validation(Required=false)]
            public string VerifiedAt { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id-001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
