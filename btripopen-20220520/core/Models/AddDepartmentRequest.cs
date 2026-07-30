// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AddDepartmentRequest : TeaModel {
        /// <summary>
        /// <para>The department name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统研发部</para>
        /// </summary>
        [NameInMap("dept_name")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        /// <summary>
        /// <para>The department manager information.</para>
        /// </summary>
        [NameInMap("manager_employee_id_list")]
        [Validation(Required=false)]
        public List<string> ManagerEmployeeIdList { get; set; }

        /// <summary>
        /// <para>The custom department ID defined by the enterprise.</para>
        /// <list type="bullet">
        /// <item><description>Ensure that this parameter value is unique.</description></item>
        /// <item><description>The default root department ID is 1. Do not pass 1 for this parameter.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>out_dept_0001</para>
        /// </summary>
        [NameInMap("out_dept_id")]
        [Validation(Required=false)]
        public string OutDeptId { get; set; }

        /// <summary>
        /// <para>The parent department ID.</para>
        /// <list type="bullet">
        /// <item><description>The parent department ID cannot be the same as the department ID.</description></item>
        /// <item><description>Ensure that the parent department information already exists in Alibaba Business Travel.</description></item>
        /// <item><description>To place the new department under the root department, set this field to 1 or leave it empty.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dept_0001</para>
        /// </summary>
        [NameInMap("out_dept_pid")]
        [Validation(Required=false)]
        public string OutDeptPid { get; set; }

    }

}
