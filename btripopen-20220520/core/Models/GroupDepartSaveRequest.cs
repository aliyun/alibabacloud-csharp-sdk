// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class GroupDepartSaveRequest : TeaModel {
        /// <summary>
        /// <para>The department name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试部门</para>
        /// </summary>
        [NameInMap("dept_name")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        /// <summary>
        /// <para>The department manager ID.</para>
        /// <list type="bullet">
        /// <item><description>If the department has multiple managers, pass the values in the format <c>[manager1|manager2|manager3]</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>001|002|003</para>
        /// </summary>
        [NameInMap("manager_ids")]
        [Validation(Required=false)]
        public string ManagerIds { get; set; }

        /// <summary>
        /// <para>The department ID. The default root department ID in Alibaba Business Travel is 1. Do not use this value when passing parameters to avoid call failures.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1001</para>
        /// </summary>
        [NameInMap("outer_dept_id")]
        [Validation(Required=false)]
        public string OuterDeptId { get; set; }

        /// <summary>
        /// <para>The parent department ID. The default root department ID in Alibaba Business Travel is 1. Do not use this value when passing parameters to avoid call failures.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("outer_dept_pid")]
        [Validation(Required=false)]
        public string OuterDeptPid { get; set; }

        /// <summary>
        /// <para>Specifies whether the department is active. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Active.</description></item>
        /// <item><description>1: Inactive.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The list of enterprise IDs to which the department belongs. <b>Required parameter</b>.</para>
        /// </summary>
        [NameInMap("sub_corp_id_list")]
        [Validation(Required=false)]
        public List<string> SubCorpIdList { get; set; }

        /// <summary>
        /// <para><b>Deprecated. No input required.</b></para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("sync_group")]
        [Validation(Required=false)]
        public bool? SyncGroup { get; set; }

    }

}
