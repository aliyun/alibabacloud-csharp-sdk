// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class AddUserToAuthorizationRuleRequest : TeaModel {
        /// <summary>
        /// <para>The authorization rule ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arrule_01kf143ug06fg7m9f43u7vahxxxx</para>
        /// </summary>
        [NameInMap("AuthorizationRuleId")]
        [Validation(Required=false)]
        public string AuthorizationRuleId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate a parameter value, but make sure that the value is unique among different requests. The ClientToken value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see References <a href="https://www.alibabacloud.com/help/zh/ecs/developer-reference/how-to-ensure-idempotence">How to ensure idempotence</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The account ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The time range of the validity period. This parameter takes effect only when <b>ValidityType</b> is set to <b>time_bound</b>.</para>
        /// </summary>
        [NameInMap("ValidityPeriod")]
        [Validation(Required=false)]
        public AddUserToAuthorizationRuleRequestValidityPeriod ValidityPeriod { get; set; }
        public class AddUserToAuthorizationRuleRequestValidityPeriod : TeaModel {
            /// <summary>
            /// <para>The end time of the validity period. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1704062061000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The start time of the validity period. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1704042061000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The validity type of the relationship. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>permanent: permanent</description></item>
        /// <item><description>time_bound: custom time range.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>permanent</para>
        /// </summary>
        [NameInMap("ValidityType")]
        [Validation(Required=false)]
        public string ValidityType { get; set; }

    }

}
