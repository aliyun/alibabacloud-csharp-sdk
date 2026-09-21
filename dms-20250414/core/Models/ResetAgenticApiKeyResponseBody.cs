// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ResetAgenticApiKeyResponseBody : TeaModel {
        /// <summary>
        /// <para>The Access Token information returned after a successful reset. The Secret field contains the new plaintext Secret, which is returned only once in this response.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ResetAgenticApiKeyResponseBodyData Data { get; set; }
        public class ResetAgenticApiKeyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Agent to which the Access Token belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-7f3c9a2b</para>
            /// </summary>
            [NameInMap("AgentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The name of the Agent to which the Access Token belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-data-agent</para>
            /// </summary>
            [NameInMap("AgentName")]
            [Validation(Required=false)]
            public string AgentName { get; set; }

            /// <summary>
            /// <para>The type of the Agent to which the Access Token belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>HUMAN_BOUND: fully inherits the permissions of the associated user.</description></item>
            /// <item><description>PERMISSION_NARROW: narrows the permissions based on the associated user\&quot;s permission baseline.</description></item>
            /// <item><description>AGENT_BOUND: inherits the permissions of the parent Agent.</description></item>
            /// <item><description>STANDALONE: holds permissions as an independent identity principal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>STANDALONE</para>
            /// </summary>
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            /// <summary>
            /// <para>The time when the Access Token was created, in the yyyy-MM-dd HH:mm:ss format (UTC+8). This value remains unchanged after the reset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-13 08:00:00</para>
            /// </summary>
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The user ID of the Access Token creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27400000000000001</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para>The display name of the Access Token creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("CreatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <para>The description of the Access Token. This value remains unchanged after the reset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Access token used by the data analysis agent</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The expiration time of the Access Token, in the yyyy-MM-dd HH:mm:ss format (UTC+8). If ExpireAfterSeconds is specified, the expiration time is recalculated from the time of the reset. If ExpireAfterSeconds is not specified, the original expiration time is retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2027-05-13 10:20:30</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The ID of the reset Access Token. This value remains unchanged after the reset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the Access Token has been revoked. An Access Token returned after a successful reset is always in the non-revoked state (false).</para>
            /// </summary>
            [NameInMap("IsRevoked")]
            [Validation(Required=false)]
            public bool? IsRevoked { get; set; }

            /// <summary>
            /// <para>The visible prefix of the Access Token, which is used to identify the Access Token without exposing the full Secret. This value remains unchanged after the reset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dms_sk_3f9a</para>
            /// </summary>
            [NameInMap("KeyPrefix")]
            [Validation(Required=false)]
            public string KeyPrefix { get; set; }

            /// <summary>
            /// <para>The time when the Access Token was last used, in the yyyy-MM-dd HH:mm:ss format (UTC+8). This value is empty if the Access Token has never been used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-13 09:15:00</para>
            /// </summary>
            [NameInMap("LastUsedTime")]
            [Validation(Required=false)]
            public string LastUsedTime { get; set; }

            /// <summary>
            /// <para>The name of the Access Token. This value remains unchanged after the reset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod-readonly-key</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The new plaintext Secret generated by this reset. This value is returned only once in this response and will not be returned by any subsequent operation. Store it securely right away. The old Secret becomes invalid immediately after the reset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dms_sk_3f9a1c8e5b7d4062a1f6c9e2b8d05a3f</para>
            /// </summary>
            [NameInMap("Secret")]
            [Validation(Required=false)]
            public string Secret { get; set; }

            /// <summary>
            /// <para>The credential source of the Access Token. The reset operation supports only Access Tokens issued by the console. Therefore, the value is always console.</para>
            /// 
            /// <b>Example:</b>
            /// <para>console</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The reminder information related to this reset, such as a notice that the new Secret is returned only once and must be stored immediately. This value is empty if no reminder exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The new secret is shown only once. Please store it securely now.</para>
            /// </summary>
            [NameInMap("Warning")]
            [Validation(Required=false)]
            public string Warning { get; set; }

        }

        /// <summary>
        /// <para>The error code returned when the request fails. You can use this code to programmatically determine the failure type. This value is empty when the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACCESS_TOKEN_NOT_FOUND</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the request fails. This message helps you locate the issue. This value is empty when the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>access token not found: 1024</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The unique request ID, which is used for troubleshooting and log correlation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6C-2C4DD51BD5E7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. A value of true indicates that the reset was successful. A value of false indicates a failure. In this case, check ErrorCode and ErrorMessage to identify the cause.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
