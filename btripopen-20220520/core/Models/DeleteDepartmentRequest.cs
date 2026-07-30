// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class DeleteDepartmentRequest : TeaModel {
        /// <summary>
        /// <para>The custom department ID defined by the enterprise.</para>
        /// <list type="bullet">
        /// <item><description>Ensure this parameter is correct. Otherwise, the wrong department may be deleted.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>out_dept_0001</para>
        /// </summary>
        [NameInMap("out_dept_id")]
        [Validation(Required=false)]
        public string OutDeptId { get; set; }

    }

}
