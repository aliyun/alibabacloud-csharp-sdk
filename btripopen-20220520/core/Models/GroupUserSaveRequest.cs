// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class GroupUserSaveRequest : TeaModel {
        [NameInMap("job_no")]
        [Validation(Required=false)]
        public string JobNo { get; set; }

        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("real_name_en")]
        [Validation(Required=false)]
        public string RealNameEn { get; set; }

        [NameInMap("sub_corp_id_list")]
        [Validation(Required=false)]
        public List<GroupUserSaveRequestSubCorpIdList> SubCorpIdList { get; set; }
        public class GroupUserSaveRequestSubCorpIdList : TeaModel {
            [NameInMap("depart_ids")]
            [Validation(Required=false)]
            public List<string> DepartIds { get; set; }

            [NameInMap("leave_status")]
            [Validation(Required=false)]
            public int? LeaveStatus { get; set; }

            [NameInMap("manager_user_id")]
            [Validation(Required=false)]
            public string ManagerUserId { get; set; }

            [NameInMap("position_level")]
            [Validation(Required=false)]
            public string PositionLevel { get; set; }

            [NameInMap("sub_corp_id")]
            [Validation(Required=false)]
            public string SubCorpId { get; set; }

        }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
