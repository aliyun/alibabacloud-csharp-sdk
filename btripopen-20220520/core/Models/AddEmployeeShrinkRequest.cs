// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AddEmployeeShrinkRequest : TeaModel {
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        [NameInMap("base_city_code_list")]
        [Validation(Required=false)]
        public string BaseCityCodeListShrink { get; set; }

        [NameInMap("birthday")]
        [Validation(Required=false)]
        public string Birthday { get; set; }

        [NameInMap("cert_list")]
        [Validation(Required=false)]
        public string CertListShrink { get; set; }

        [NameInMap("custom_role_code_list")]
        [Validation(Required=false)]
        public string CustomRoleCodeListShrink { get; set; }

        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("gender")]
        [Validation(Required=false)]
        public string Gender { get; set; }

        [NameInMap("is_admin")]
        [Validation(Required=false)]
        public bool? IsAdmin { get; set; }

        [NameInMap("is_boss")]
        [Validation(Required=false)]
        public bool? IsBoss { get; set; }

        [NameInMap("is_dept_leader")]
        [Validation(Required=false)]
        public bool? IsDeptLeader { get; set; }

        [NameInMap("job_no")]
        [Validation(Required=false)]
        public string JobNo { get; set; }

        [NameInMap("manager_user_id")]
        [Validation(Required=false)]
        public string ManagerUserId { get; set; }

        [NameInMap("out_dept_id_list")]
        [Validation(Required=false)]
        public string OutDeptIdListShrink { get; set; }

        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("position_level")]
        [Validation(Required=false)]
        public string PositionLevel { get; set; }

        [NameInMap("real_name")]
        [Validation(Required=false)]
        public string RealName { get; set; }

        [NameInMap("real_name_en")]
        [Validation(Required=false)]
        public string RealNameEn { get; set; }

        [NameInMap("union_id")]
        [Validation(Required=false)]
        public string UnionId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("user_nick")]
        [Validation(Required=false)]
        public string UserNick { get; set; }

    }

}
