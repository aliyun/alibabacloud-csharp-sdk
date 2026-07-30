// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ExternalUserAddRequest : TeaModel {
        /// <summary>
        /// <para>The date of birth in the format yyyy-MM-dd.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000-01-02</para>
        /// </summary>
        [NameInMap("birthday")]
        [Validation(Required=false)]
        public string Birthday { get; set; }

        /// <summary>
        /// <para>The list of certificates.</para>
        /// </summary>
        [NameInMap("cert_request_list")]
        [Validation(Required=false)]
        public List<ExternalUserAddRequestCertRequestList> CertRequestList { get; set; }
        public class ExternalUserAddRequestCertRequestList : TeaModel {
            /// <summary>
            /// <para>The certificate expiration date in the format yyyy-MM-dd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2034-10-01</para>
            /// </summary>
            [NameInMap("cert_expired_time")]
            [Validation(Required=false)]
            public string CertExpiredTime { get; set; }

            /// <summary>
            /// <para>The two-letter country code of the issuing country.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("cert_nation")]
            [Validation(Required=false)]
            public string CertNation { get; set; }

            /// <summary>
            /// <para>The certificate number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>330101199010010213</para>
            /// </summary>
            [NameInMap("cert_no")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            /// <summary>
            /// <para>The certificate type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("cert_type")]
            [Validation(Required=false)]
            public int? CertType { get; set; }

            /// <summary>
            /// <para>The two-letter country code for nationality.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CN</para>
            /// </summary>
            [NameInMap("nationality")]
            [Validation(Required=false)]
            public string Nationality { get; set; }

        }

        /// <summary>
        /// <para>The email address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:zhangsan@alibaba-inc.com">zhangsan@alibaba-inc.com</a></para>
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>The unique ID of the external traveler within the enterprise scope.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0012</para>
        /// </summary>
        [NameInMap("external_user_id")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// <para>The phone number. This parameter is required. For specific enterprises, contact the administrator to apply for an exemption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13438009765</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <para>The real name in Chinese.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("real_name")]
        [Validation(Required=false)]
        public string RealName { get; set; }

        /// <summary>
        /// <para>The passport name in pinyin, in the format LastName/FirstName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhang/san</para>
        /// </summary>
        [NameInMap("real_name_en")]
        [Validation(Required=false)]
        public string RealNameEn { get; set; }

        /// <summary>
        /// <para>The user type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("user_type")]
        [Validation(Required=false)]
        public int? UserType { get; set; }

    }

}
