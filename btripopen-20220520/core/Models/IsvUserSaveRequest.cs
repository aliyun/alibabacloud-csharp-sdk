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
            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public long? DepartId { get; set; }

            [NameInMap("email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("job_no")]
            [Validation(Required=false)]
            public string JobNo { get; set; }

            [NameInMap("leave_status")]
            [Validation(Required=false)]
            public int? LeaveStatus { get; set; }

            [NameInMap("manager_user_id")]
            [Validation(Required=false)]
            public string ManagerUserId { get; set; }

            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("position")]
            [Validation(Required=false)]
            public string Position { get; set; }

            [NameInMap("position_level")]
            [Validation(Required=false)]
            public string PositionLevel { get; set; }

            [NameInMap("real_name_en")]
            [Validation(Required=false)]
            public string RealNameEn { get; set; }

            [NameInMap("third_depart_id")]
            [Validation(Required=false)]
            public string ThirdDepartId { get; set; }

            [NameInMap("third_depart_id_list")]
            [Validation(Required=false)]
            public List<string> ThirdDepartIdList { get; set; }

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
