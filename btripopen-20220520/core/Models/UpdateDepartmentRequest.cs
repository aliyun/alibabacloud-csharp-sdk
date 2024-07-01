// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class UpdateDepartmentRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dept_name")]
        [Validation(Required=false)]
        public string DeptName { get; set; }

        [NameInMap("manager_employee_id_list")]
        [Validation(Required=false)]
        public List<string> ManagerEmployeeIdList { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("out_dept_id")]
        [Validation(Required=false)]
        public string OutDeptId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("out_dept_pid")]
        [Validation(Required=false)]
        public string OutDeptPid { get; set; }

    }

}
