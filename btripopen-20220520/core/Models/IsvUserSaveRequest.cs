// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IsvUserSaveRequest : TeaModel {
        [NameInMap("user_list")]
        [Validation(Required=false)]
        public List<IsvUserSaveRequestUserList> UserList { get; set; }
        public class IsvUserSaveRequestUserList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>330100,310100</para>
            /// </summary>
            [NameInMap("base_city_code")]
            [Validation(Required=false)]
            public string BaseCityCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000-01-01</para>
            /// </summary>
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            [NameInMap("cert_list")]
            [Validation(Required=false)]
            public List<IsvUserSaveRequestUserListCertList> CertList { get; set; }
            public class IsvUserSaveRequestUserListCertList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2050-01-01</para>
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
                /// <para>110101********1234</para>
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
                /// <para>CN</para>
                /// </summary>
                [NameInMap("nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public long? DepartId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:123@163.com">123@163.com</a></para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>M</para>
            /// </summary>
            [NameInMap("gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("is_admin")]
            [Validation(Required=false)]
            public bool? IsAdmin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8797</para>
            /// </summary>
            [NameInMap("job_no")]
            [Validation(Required=false)]
            public string JobNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("leave_status")]
            [Validation(Required=false)]
            public int? LeaveStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("manager_user_id")]
            [Validation(Required=false)]
            public string ManagerUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>15364762829</para>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>产品经理</para>
            /// </summary>
            [NameInMap("position")]
            [Validation(Required=false)]
            public string Position { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("position_level")]
            [Validation(Required=false)]
            public string PositionLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ceshi</para>
            /// </summary>
            [NameInMap("real_name_en")]
            [Validation(Required=false)]
            public string RealNameEn { get; set; }

            [NameInMap("role_id_list")]
            [Validation(Required=false)]
            public List<string> RoleIdList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("third_depart_id")]
            [Validation(Required=false)]
            public string ThirdDepartId { get; set; }

            [NameInMap("third_depart_id_list")]
            [Validation(Required=false)]
            public List<string> ThirdDepartIdList { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>三儿</para>
            /// </summary>
            [NameInMap("user_nick")]
            [Validation(Required=false)]
            public string UserNick { get; set; }

        }

    }

}
