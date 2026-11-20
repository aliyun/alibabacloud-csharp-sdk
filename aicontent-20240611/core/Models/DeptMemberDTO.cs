// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class DeptMemberDTO : TeaModel {
        /// <summary>
        /// <para>The comma-separated list of authorized model IDs. This field is valid only when include_authorization is specified. An empty value indicates that the models are inherited or all models are authorized.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("allowedModels")]
        [Validation(Required=false)]
        public string AllowedModels { get; set; }

        /// <summary>
        /// <para>The authorization configuration. Valid values: inherit: Inherited from the department. custom: Customized. This field is valid only when include_authorization is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inherit</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public string AuthConfig { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The member user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The number of active keys that belong to the member. This field is valid only when include_authorization is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("keyCount")]
        [Validation(Required=false)]
        public int? KeyCount { get; set; }

        /// <summary>
        /// <para>The logon name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhangsan</para>
        /// </summary>
        [NameInMap("loginName")]
        [Validation(Required=false)]
        public string LoginName { get; set; }

        /// <summary>
        /// <para>The monthly balance. This field is valid only when include_balance is specified. The value is 0 if the feature is not activated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.00</para>
        /// </summary>
        [NameInMap("monthlyBalance")]
        [Validation(Required=false)]
        public double? MonthlyBalance { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zhang San</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The permanent balance. This field is valid only when include_balance is specified. The value is 0 if the feature is not activated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20.00</para>
        /// </summary>
        [NameInMap("permanentBalance")]
        [Validation(Required=false)]
        public double? PermanentBalance { get; set; }

        /// <summary>
        /// <para>The mobile phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>138****0000</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>The role code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>member</para>
        /// </summary>
        [NameInMap("roleCode")]
        [Validation(Required=false)]
        public string RoleCode { get; set; }

        /// <summary>
        /// <para>The role name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Member</para>
        /// </summary>
        [NameInMap("roleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
