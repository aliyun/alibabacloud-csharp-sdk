// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class GroupDepartSaveShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dept_name")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        [NameInMap("manager_ids")]
        [Validation(Required=false)]
        public string ManagerIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>001</para>
        /// </summary>
        [NameInMap("outer_dept_id")]
        [Validation(Required=false)]
        public string OuterDeptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>002</para>
        /// </summary>
        [NameInMap("outer_dept_pid")]
        [Validation(Required=false)]
        public string OuterDeptPid { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("sub_corp_id_list")]
        [Validation(Required=false)]
        public string SubCorpIdListShrink { get; set; }

        [NameInMap("sync_group")]
        [Validation(Required=false)]
        public bool? SyncGroup { get; set; }

    }

}
