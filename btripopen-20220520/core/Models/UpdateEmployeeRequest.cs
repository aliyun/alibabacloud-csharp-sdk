// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class UpdateEmployeeRequest : TeaModel {
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
        public List<string> BaseCityCodeList { get; set; }

        [NameInMap("base_location_list")]
        [Validation(Required=false)]
        public List<UpdateEmployeeRequestBaseLocationList> BaseLocationList { get; set; }
        public class UpdateEmployeeRequestBaseLocationList : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000-01-02</para>
        /// </summary>
        [NameInMap("birthday")]
        [Validation(Required=false)]
        public string Birthday { get; set; }

        [NameInMap("cert_list")]
        [Validation(Required=false)]
        public List<UpdateEmployeeRequestCertList> CertList { get; set; }
        public class UpdateEmployeeRequestCertList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2000-01-02</para>
            /// </summary>
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2099-03-12</para>
            /// </summary>
            [NameInMap("cert_expired_time")]
            [Validation(Required=false)]
            public string CertExpiredTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("cert_nation")]
            [Validation(Required=false)]
            public string CertNation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("cert_no")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("cert_type")]
            [Validation(Required=false)]
            public int? CertType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>F</para>
            /// </summary>
            [NameInMap("gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("nationality")]
            [Validation(Required=false)]
            public string Nationality { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13111111111</para>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

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

        }

        [NameInMap("custom_role_code_list")]
        [Validation(Required=false)]
        public List<string> CustomRoleCodeList { get; set; }

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
        public List<string> OutDeptIdList { get; set; }

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
