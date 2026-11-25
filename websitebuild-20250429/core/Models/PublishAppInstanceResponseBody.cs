// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class PublishAppInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The access denial information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>Specifies whether retries are allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("AllowRetry")]
        [Validation(Required=false)]
        public bool? AllowRetry { get; set; }

        /// <summary>
        /// <para>The app name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dewuApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ERROR-oo1</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic message. This parameter is currently unused and can be ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM_ERROR</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The returned error parameters.</para>
        /// </summary>
        [NameInMap("ErrorArgs")]
        [Validation(Required=false)]
        public List<object> ErrorArgs { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Module")]
        [Validation(Required=false)]
        public PublishAppInstanceResponseBodyModule Module { get; set; }
        public class PublishAppInstanceResponseBodyModule : TeaModel {
            [NameInMap("ArtifactDigest")]
            [Validation(Required=false)]
            public string ArtifactDigest { get; set; }

            [NameInMap("AuditId")]
            [Validation(Required=false)]
            public string AuditId { get; set; }

            [NameInMap("CandidateId")]
            [Validation(Required=false)]
            public string CandidateId { get; set; }

            [NameInMap("CandidateStatus")]
            [Validation(Required=false)]
            public string CandidateStatus { get; set; }

            [NameInMap("CommitHash")]
            [Validation(Required=false)]
            public string CommitHash { get; set; }

            [NameInMap("PlatformAppid")]
            [Validation(Required=false)]
            public string PlatformAppid { get; set; }

            [NameInMap("PluginDeclarationHash")]
            [Validation(Required=false)]
            public string PluginDeclarationHash { get; set; }

            [NameInMap("PluginState")]
            [Validation(Required=false)]
            public string PluginState { get; set; }

            [NameInMap("PrivacyDraftId")]
            [Validation(Required=false)]
            public string PrivacyDraftId { get; set; }

            [NameInMap("PrivacyRevision")]
            [Validation(Required=false)]
            public string PrivacyRevision { get; set; }

            [NameInMap("PublishEnv")]
            [Validation(Required=false)]
            public string PublishEnv { get; set; }

            [NameInMap("PublishNumber")]
            [Validation(Required=false)]
            public string PublishNumber { get; set; }

            /// <summary>
            /// <para>The publish order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>231</para>
            /// </summary>
            [NameInMap("PublishOrderId")]
            [Validation(Required=false)]
            public long? PublishOrderId { get; set; }

            [NameInMap("ReadbackStatus")]
            [Validation(Required=false)]
            public string ReadbackStatus { get; set; }

            [NameInMap("SubmitIntentStatus")]
            [Validation(Required=false)]
            public string SubmitIntentStatus { get; set; }

            [NameInMap("UpdatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

            [NameInMap("UploadSequence")]
            [Validation(Required=false)]
            public long? UploadSequence { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEM.ERROR</para>
        /// </summary>
        [NameInMap("RootErrorCode")]
        [Validation(Required=false)]
        public string RootErrorCode { get; set; }

        /// <summary>
        /// <para>The exception message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>System exception</para>
        /// </summary>
        [NameInMap("RootErrorMsg")]
        [Validation(Required=false)]
        public string RootErrorMsg { get; set; }

        /// <summary>
        /// <para>The reserved parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Synchro")]
        [Validation(Required=false)]
        public bool? Synchro { get; set; }

    }

}
