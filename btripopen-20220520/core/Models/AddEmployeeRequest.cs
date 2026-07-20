// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AddEmployeeRequest : TeaModel {
        /// <summary>
        /// <para>The account email address. This parameter can be specified when the enterprise activation method is email activation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>j*********@example.com</para>
        /// </summary>
        [NameInMap("account_email")]
        [Validation(Required=false)]
        public string AccountEmail { get; set; }

        /// <summary>
        /// <para>The account phone number. For enterprises with international phone numbers enabled, specify international numbers, Hong Kong (China), Macao (China), and Taiwan (China) numbers in the format +xx-xxxxxx.</para>
        /// 
        /// <b>Example:</b>
        /// <para>+86-18812345678</para>
        /// </summary>
        [NameInMap("account_phone")]
        [Validation(Required=false)]
        public string AccountPhone { get; set; }

        /// <summary>
        /// <para>The custom extension field for the employee, which supports key-value pairs.</para>
        /// <list type="bullet">
        /// <item><description>Format: JSON string.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;sio&quot;: &quot;123&quot;,
        ///     &quot;location&quot;: &quot;22222&quot;,
        ///     &quot;isForeigner&quot;: &quot;Y&quot;
        /// }</para>
        /// </summary>
        [NameInMap("attribute")]
        [Validation(Required=false)]
        public string Attribute { get; set; }

        /// <summary>
        /// <para>The avatar of the employee. Specify the URL of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/example.jpg">https://example.com/example.jpg</a></para>
        /// </summary>
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// <para>The 6-digit administrative code of the work location.</para>
        /// <list type="bullet">
        /// <item><description>A maximum of two different administrative codes can be specified.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("base_city_code_list")]
        [Validation(Required=false)]
        public List<string> BaseCityCodeList { get; set; }

        /// <summary>
        /// <para>The base location information of the employee.</para>
        /// </summary>
        [NameInMap("base_location_list")]
        [Validation(Required=false)]
        public List<AddEmployeeRequestBaseLocationList> BaseLocationList { get; set; }
        public class AddEmployeeRequestBaseLocationList : TeaModel {
            /// <summary>
            /// <para>The 6-digit administrative division code.</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The administrative division level: province or city.</para>
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

        }

        /// <summary>
        /// <para>The birthday of the employee.</para>
        /// <list type="bullet">
        /// <item><description>Format: yy-MM-dd.</description></item>
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
        public List<AddEmployeeRequestCertList> CertList { get; set; }
        public class AddEmployeeRequestCertList : TeaModel {
            /// <summary>
            /// <para>The birthday of the employee.</para>
            /// <list type="bullet">
            /// <item><description>Format: yy-MM-dd.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2000-01-01</para>
            /// </summary>
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            /// <summary>
            /// <para>The expiration date of the certificate.</para>
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
            /// <para>The gender of the employee, which must be consistent with the certificate information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>F</para>
            /// </summary>
            [NameInMap("gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }

            /// <summary>
            /// <para>The two-letter country/region code (Country Code) of the employee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("nationality")]
            [Validation(Required=false)]
            public string Nationality { get; set; }

            /// <summary>
            /// <para>The mobile phone number of the employee.</para>
            /// 
            /// <b>Example:</b>
            /// <para>131****8888</para>
            /// </summary>
            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The name of the employee, which must be consistent with the certificate information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("real_name")]
            [Validation(Required=false)]
            public string RealName { get; set; }

            /// <summary>
            /// <para>The English name of the employee. Follow these format requirements:</para>
            /// <list type="bullet">
            /// <item><description>Separate the last name and first name with &quot;/&quot;, for example: LastName/FirstName.</description></item>
            /// <item><description>Do not include spaces between the last name and first name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>John/Wilson</para>
            /// </summary>
            [NameInMap("real_name_en")]
            [Validation(Required=false)]
            public string RealNameEn { get; set; }

        }

        /// <summary>
        /// <para>The collection of role IDs associated with the employee. The number of roles associated with a single employee must be less than or equal to 200. Otherwise, the employee synchronization fails.</para>
        /// </summary>
        [NameInMap("custom_role_code_list")]
        [Validation(Required=false)]
        public List<string> CustomRoleCodeList { get; set; }

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
        /// <para>F</para>
        /// </summary>
        [NameInMap("gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// <para>Specifies whether the employee is an Alibaba Business Travel enterprise administrator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("is_admin")]
        [Validation(Required=false)]
        public bool? IsAdmin { get; set; }

        /// <summary>
        /// <para>Specifies whether the employee is the boss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("is_boss")]
        [Validation(Required=false)]
        public bool? IsBoss { get; set; }

        /// <summary>
        /// <para>Specifies whether the employee is a department manager.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("is_dept_leader")]
        [Validation(Required=false)]
        public bool? IsDeptLeader { get; set; }

        /// <summary>
        /// <para>The employee number, which serves as a unique identifier for the employee along with <c>user_id</c>. Ensure that the value is unique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job_1234</para>
        /// </summary>
        [NameInMap("job_no")]
        [Validation(Required=false)]
        public string JobNo { get; set; }

        /// <summary>
        /// <para>The ID of the direct manager of the employee.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_001</para>
        /// </summary>
        [NameInMap("manager_user_id")]
        [Validation(Required=false)]
        public string ManagerUserId { get; set; }

        /// <summary>
        /// <para>The list of departments to which the employee belongs.</para>
        /// </summary>
        [NameInMap("out_dept_id_list")]
        [Validation(Required=false)]
        public List<string> OutDeptIdList { get; set; }

        /// <summary>
        /// <para>The mobile phone number of the employee.</para>
        /// <list type="bullet">
        /// <item><description>This field is commonly used for booking business travel services across various categories. <b>In this case, it is required.</b></description></item>
        /// <item><description>If your enterprise is a government agency or other special enterprise, call 400-800-5890 to contact an Alibaba Business Travel customer service representative.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>131****8888</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>The position level of the employee, which is commonly used to match different travel standards.</para>
        /// 
        /// <b>Example:</b>
        /// <para>高级</para>
        /// </summary>
        [NameInMap("position_level")]
        [Validation(Required=false)]
        public string PositionLevel { get; set; }

        /// <summary>
        /// <para>The name of the employee.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("real_name")]
        [Validation(Required=false)]
        public string RealName { get; set; }

        /// <summary>
        /// <para>The English name of the employee. Follow these format requirements:</para>
        /// <list type="bullet">
        /// <item><description>Separate the last name and first name with &quot;/&quot;, for example: LastName/FirstName.</description></item>
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
        /// <para>The unique identifier of the same employee across multiple enterprises (parent and subsidiary enterprises).</para>
        /// 
        /// <b>Example:</b>
        /// <para>union_0123</para>
        /// </summary>
        [NameInMap("union_id")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        /// <summary>
        /// <para>The employee ID, which is the unique identifier of the employee within the enterprise. Ensure that this value is unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_1234</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The nickname of the employee.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>弓长</para>
        /// </summary>
        [NameInMap("user_nick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

    }

}
