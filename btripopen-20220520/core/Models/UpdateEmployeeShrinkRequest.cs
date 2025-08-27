// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class UpdateEmployeeShrinkRequest : TeaModel {
        [NameInMap("account_email")]
        [Validation(Required=false)]
        public string AccountEmail { get; set; }

        [NameInMap("account_phone")]
        [Validation(Required=false)]
        public string AccountPhone { get; set; }

        [NameInMap("attribute")]
        [Validation(Required=false)]
        public string Attribute { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://static-legacy.dingtalk.com/media/lADPF8XMoxJeUkbNA2LNA5s_923_866.jpg">https://static-legacy.dingtalk.com/media/lADPF8XMoxJeUkbNA2LNA5s_923_866.jpg</a></para>
        /// </summary>
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        [NameInMap("base_city_code_list")]
        [Validation(Required=false)]
        public string BaseCityCodeListShrink { get; set; }

        [NameInMap("base_location_list")]
        [Validation(Required=false)]
        public string BaseLocationListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000-01-02</para>
        /// </summary>
        [NameInMap("birthday")]
        [Validation(Required=false)]
        public string Birthday { get; set; }

        [NameInMap("cert_list")]
        [Validation(Required=false)]
        public string CertListShrink { get; set; }

        [NameInMap("custom_role_code_list")]
        [Validation(Required=false)]
        public string CustomRoleCodeListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:123@163.com">123@163.com</a></para>
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F</para>
        /// </summary>
        [NameInMap("gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("is_admin")]
        [Validation(Required=false)]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("is_boss")]
        [Validation(Required=false)]
        public bool? IsBoss { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("is_dept_leader")]
        [Validation(Required=false)]
        public bool? IsDeptLeader { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("job_no")]
        [Validation(Required=false)]
        public string JobNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user456</para>
        /// </summary>
        [NameInMap("manager_user_id")]
        [Validation(Required=false)]
        public string ManagerUserId { get; set; }

        [NameInMap("out_dept_id_list")]
        [Validation(Required=false)]
        public string OutDeptIdListShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>13111111111</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>M4</para>
        /// </summary>
        [NameInMap("position_level")]
        [Validation(Required=false)]
        public string PositionLevel { get; set; }

        [NameInMap("real_name")]
        [Validation(Required=false)]
        public string RealName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>John/Wilson</para>
        /// </summary>
        [NameInMap("real_name_en")]
        [Validation(Required=false)]
        public string RealNameEn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user123</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("user_nick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

    }

}
