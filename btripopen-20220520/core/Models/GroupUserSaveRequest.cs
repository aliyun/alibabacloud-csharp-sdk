// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class GroupUserSaveRequest : TeaModel {
        [NameInMap("base_city_code")]
        [Validation(Required=false)]
        public string BaseCityCode { get; set; }

        [NameInMap("birthday")]
        [Validation(Required=false)]
        public string Birthday { get; set; }

        [NameInMap("cert_list")]
        [Validation(Required=false)]
        public List<GroupUserSaveRequestCertList> CertList { get; set; }
        public class GroupUserSaveRequestCertList : TeaModel {
            [NameInMap("cert_expired_time")]
            [Validation(Required=false)]
            public string CertExpiredTime { get; set; }

            [NameInMap("cert_nation")]
            [Validation(Required=false)]
            public string CertNation { get; set; }

            [NameInMap("cert_no")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            [NameInMap("cert_type")]
            [Validation(Required=false)]
            public int? CertType { get; set; }

            [NameInMap("nationality")]
            [Validation(Required=false)]
            public string Nationality { get; set; }

        }

        [NameInMap("gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("job_no")]
        [Validation(Required=false)]
        public string JobNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>18000000000</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ce/shi</para>
        /// </summary>
        [NameInMap("real_name_en")]
        [Validation(Required=false)]
        public string RealNameEn { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sub_corp_id_list")]
        [Validation(Required=false)]
        public List<GroupUserSaveRequestSubCorpIdList> SubCorpIdList { get; set; }
        public class GroupUserSaveRequestSubCorpIdList : TeaModel {
            [NameInMap("depart_ids")]
            [Validation(Required=false)]
            public List<string> DepartIds { get; set; }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("leave_status")]
            [Validation(Required=false)]
            public int? LeaveStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("manager_user_id")]
            [Validation(Required=false)]
            public string ManagerUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("position_level")]
            [Validation(Required=false)]
            public string PositionLevel { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>btrip123</para>
            /// </summary>
            [NameInMap("sub_corp_id")]
            [Validation(Required=false)]
            public string SubCorpId { get; set; }

        }

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
        /// </summary>
        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
