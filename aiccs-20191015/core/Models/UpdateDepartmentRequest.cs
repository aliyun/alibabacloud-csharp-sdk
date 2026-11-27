// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class UpdateDepartmentRequest : TeaModel {
        /// <summary>
        /// <para>The department ID. You can call the <a href="https://help.aliyun.com/document_detail/2717975.html">GetAllDepartment</a> operation and view the <b>DepartmentId</b> response parameter to obtain the department ID.</para>
        /// <remarks>
        /// <para>This parameter cannot be updated.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("DepartmentId")]
        [Validation(Required=false)]
        public long? DepartmentId { get; set; }

        /// <summary>
        /// <para>The department name.</para>
        /// <remarks>
        /// <para>This parameter can be updated.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Department A</para>
        /// </summary>
        [NameInMap("DepartmentName")]
        [Validation(Required=false)]
        public string DepartmentName { get; set; }

        /// <summary>
        /// <para>The AICCS instance ID. You can obtain the ID from the <b>Instance Management</b> page in the left-side navigation pane of the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
