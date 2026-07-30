// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class DepartmentSaveRequest : TeaModel {
        /// <summary>
        /// <para>The list of request parameters.</para>
        /// </summary>
        [NameInMap("depart_list")]
        [Validation(Required=false)]
        public List<DepartmentSaveRequestDepartList> DepartList { get; set; }
        public class DepartmentSaveRequestDepartList : TeaModel {
            /// <summary>
            /// <para>The (legacy) department ID. Either this parameter or <c>third_depart_id</c> <b>must be specified</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dept_0001</para>
            /// </summary>
            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public long? DepartId { get; set; }

            /// <summary>
            /// <para>The department name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>产品研发部</para>
            /// </summary>
            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            /// <summary>
            /// <para>The (legacy) parent department ID of the current department. Either this parameter or <c>third_depart_pid</c> <b>must be specified</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dept_001</para>
            /// </summary>
            [NameInMap("depart_pid")]
            [Validation(Required=false)]
            public long? DepartPid { get; set; }

            /// <summary>
            /// <para>The department manager ID. If multiple managers exist, separate their IDs with a pipe character (|).</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_0001|user_0002|user_0003</para>
            /// </summary>
            [NameInMap("manager_ids")]
            [Validation(Required=false)]
            public string ManagerIds { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the department.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The (new) department ID. Either this parameter or <c>depart_id</c> <b>must be specified</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>third_dept_0001</para>
            /// </summary>
            [NameInMap("third_depart_id")]
            [Validation(Required=false)]
            public string ThirdDepartId { get; set; }

            /// <summary>
            /// <para>The (new) parent department ID of the current department. Either this parameter or <c>depart_pid</c> <b>must be specified</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>third_dept_001</para>
            /// </summary>
            [NameInMap("third_depart_pid")]
            [Validation(Required=false)]
            public string ThirdDepartPid { get; set; }

        }

    }

}
