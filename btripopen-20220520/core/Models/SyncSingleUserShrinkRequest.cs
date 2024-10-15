// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class SyncSingleUserShrinkRequest : TeaModel {
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1001</para>
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
        /// <para>72369</para>
        /// </summary>
        [NameInMap("manager_user_id")]
        [Validation(Required=false)]
        public string ManagerUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>16392740204</para>
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("position")]
        [Validation(Required=false)]
        public string Position { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("position_level")]
        [Validation(Required=false)]
        public string PositionLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ce/shi</para>
        /// </summary>
        [NameInMap("real_name_en")]
        [Validation(Required=false)]
        public string RealNameEn { get; set; }

        [NameInMap("third_depart_id_list")]
        [Validation(Required=false)]
        public string ThirdDepartIdListShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>573263</para>
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
