// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IsvUserSaveRequest : TeaModel {
        /// <summary>
        /// <para>The list of employee information.</para>
        /// <list type="bullet">
        /// <item><description>The maximum number of employees per request is 100.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("user_list")]
        [Validation(Required=false)]
        public List<IsvUserSaveRequestUserList> UserList { get; set; }
        public class IsvUserSaveRequestUserList : TeaModel {
            /// <summary>
            /// <para>The 6-digit administrative code of the work location.</para>
            /// <list type="bullet">
            /// <item><description>You can specify up to two different administrative codes.</description></item>
            /// <item><description>Format: If you need to specify two administrative codes, separate them with a comma &quot;,&quot;.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>330100,310100</para>
            /// </summary>
            [NameInMap("base_city_code")]
            [Validation(Required=false)]
            public string BaseCityCode { get; set; }

            /// <summary>
            /// <para>The birthday of the employee.</para>
            /// <list type="bullet">
            /// <item><description>Format: <c>yy-MM-dd</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2000-01-01</para>
            /// </summary>
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            /// <summary>
            /// <para>The certificate information of the employee.</para>
            /// </summary>
            [NameInMap("cert_list")]
            [Validation(Required=false)]
            public List<IsvUserSaveRequestUserListCertList> CertList { get; set; }
            public class IsvUserSaveRequestUserListCertList : TeaModel {
                /// <summary>
                /// <para>The certificate expiration date.</para>
                /// <list type="bullet">
                /// <item><description>Format: <c>yy-MM-dd</c>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2050-01-01</para>
                /// </summary>
                [NameInMap("cert_expired_time")]
                [Validation(Required=false)]
                public string CertExpiredTime { get; set; }

                /// <summary>
                /// <para>The two-letter country/region code (Country Code) of the certificate issuing country/region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("cert_nation")]
                [Validation(Required=false)]
                public string CertNation { get; set; }

                /// <summary>
                /// <para>The certificate number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110101********1234</para>
                /// </summary>
                [NameInMap("cert_no")]
                [Validation(Required=false)]
                public string CertNo { get; set; }

                /// <summary>
                /// <para>The certificate type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("cert_type")]
                [Validation(Required=false)]
                public int? CertType { get; set; }

                /// <summary>
                /// <para>The two-letter country/region code (Country Code) of the employee\&quot;s nationality.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("nationality")]
                [Validation(Required=false)]
                public string Nationality { get; set; }

            }

            /// <summary>
            /// <para>The ID of the department to which the employee belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>depart_1234</para>
            /// </summary>
            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public long? DepartId { get; set; }

            /// <summary>
            /// <para>The email address of the employee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>j*********@example.com</para>
            /// </summary>
            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The gender of the employee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>M</para>
            /// </summary>
            [NameInMap("gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            /// <summary>
            /// <para>Specifies whether the employee is an Alibaba Business Travel enterprise administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("is_admin")]
            [Validation(Required=false)]
            public bool? IsAdmin { get; set; }

            /// <summary>
            /// <para>The employee number.</para>
            /// <list type="bullet">
            /// <item><description>Like the employee ID, this is a unique identifier for the employee. Ensure uniqueness when specifying this parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>job_1234</para>
            /// </summary>
            [NameInMap("job_no")]
            [Validation(Required=false)]
            public string JobNo { get; set; }

            /// <summary>
            /// <para>The employment status of the employee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("leave_status")]
            [Validation(Required=false)]
            public int? LeaveStatus { get; set; }

            /// <summary>
            /// <para>The ID of the employee\&quot;s direct manager.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_123</para>
            /// </summary>
            [NameInMap("manager_user_id")]
            [Validation(Required=false)]
            public string ManagerUserId { get; set; }

            /// <summary>
            /// <para>The mobile phone number of the employee.</para>
            /// <list type="bullet">
            /// <item><description>Typically used for business travel booking. In this case, this parameter is required.</description></item>
            /// <item><description>If your enterprise is a government agency or other special organization, call <c>400-800-5890</c> to contact Alibaba Business Travel customer service representative first.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>131****8888</para>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The position of the employee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>产品经理</para>
            /// </summary>
            [NameInMap("position")]
            [Validation(Required=false)]
            public string Position { get; set; }

            /// <summary>
            /// <para>The position level of the employee.</para>
            /// <list type="bullet">
            /// <item><description>Typically used to match different travel policy standards.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("position_level")]
            [Validation(Required=false)]
            public string PositionLevel { get; set; }

            /// <summary>
            /// <para>The English name of the employee. Specify the value in the following format:</para>
            /// <list type="bullet">
            /// <item><description>Separate the last name and first name with &quot;/&quot;, for example: <c>LastName/FirstName</c>.</description></item>
            /// <item><description>Do not include spaces between the last name and first name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>John/Wilson</para>
            /// </summary>
            [NameInMap("real_name_en")]
            [Validation(Required=false)]
            public string RealNameEn { get; set; }

            /// <summary>
            /// <para>The collection of business travel role IDs for the employee.</para>
            /// <list type="bullet">
            /// <item><description>The number of roles associated with a single employee must be less than or equal to 200. Otherwise, the employee sync will fail.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("role_id_list")]
            [Validation(Required=false)]
            public List<string> RoleIdList { get; set; }

            /// <summary>
            /// <para>The ID of the department to which the employee belongs.</para>
            /// <list type="bullet">
            /// <item><description>Same as <c>depart_id</c>. Specify either one as a <b>required parameter</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>depart_1234</para>
            /// </summary>
            [NameInMap("third_depart_id")]
            [Validation(Required=false)]
            public string ThirdDepartId { get; set; }

            /// <summary>
            /// <para>The departments to which the employee belongs.</para>
            /// <list type="bullet">
            /// <item><description>Use this field when the employee belongs to multiple departments.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("third_depart_id_list")]
            [Validation(Required=false)]
            public List<string> ThirdDepartIdList { get; set; }

            /// <summary>
            /// <para>The employee ID.</para>
            /// <list type="bullet">
            /// <item><description>This is the unique identifier of the employee within the enterprise. Ensure uniqueness.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_1234</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The employee name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The employee nickname.</para>
            /// <list type="bullet">
            /// <item><description>If not specified, the value defaults to the <c>user_name</c> (employee name).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>三儿</para>
            /// </summary>
            [NameInMap("user_nick")]
            [Validation(Required=false)]
            public string UserNick { get; set; }

        }

    }

}
