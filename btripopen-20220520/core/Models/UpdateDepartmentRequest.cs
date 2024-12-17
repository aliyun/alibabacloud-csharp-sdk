// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class UpdateDepartmentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("dept_name")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        [NameInMap("manager_employee_id_list")]
        [Validation(Required=false)]
        public List<string> ManagerEmployeeIdList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dept123</para>
        /// </summary>
        [NameInMap("out_dept_id")]
        [Validation(Required=false)]
        public string OutDeptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dept456</para>
        /// </summary>
        [NameInMap("out_dept_pid")]
        [Validation(Required=false)]
        public string OutDeptPid { get; set; }

    }

}
