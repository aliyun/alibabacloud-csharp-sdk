// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class DeptMemberDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1,2</para>
        /// </summary>
        [NameInMap("allowedModels")]
        [Validation(Required=false)]
        public string AllowedModels { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>inherit</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public string AuthConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("keyCount")]
        [Validation(Required=false)]
        public int? KeyCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zhangsan</para>
        /// </summary>
        [NameInMap("loginName")]
        [Validation(Required=false)]
        public string LoginName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.00</para>
        /// </summary>
        [NameInMap("monthlyBalance")]
        [Validation(Required=false)]
        public double? MonthlyBalance { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>John Smith</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20.00</para>
        /// </summary>
        [NameInMap("permanentBalance")]
        [Validation(Required=false)]
        public double? PermanentBalance { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>138****0000</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>member</para>
        /// </summary>
        [NameInMap("roleCode")]
        [Validation(Required=false)]
        public string RoleCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Member</para>
        /// </summary>
        [NameInMap("roleName")]
        [Validation(Required=false)]
        public string RoleName { get; set; }

    }

}
