// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class DepartmentSaveRequest : TeaModel {
        [NameInMap("depart_list")]
        [Validation(Required=false)]
        public List<DepartmentSaveRequestDepartList> DepartList { get; set; }
        public class DepartmentSaveRequestDepartList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public long? DepartId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("depart_pid")]
            [Validation(Required=false)]
            public long? DepartPid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>001|002|003</para>
            /// </summary>
            [NameInMap("manager_ids")]
            [Validation(Required=false)]
            public string ManagerIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testdepartid001</para>
            /// </summary>
            [NameInMap("third_depart_id")]
            [Validation(Required=false)]
            public string ThirdDepartId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testdepartpid001</para>
            /// </summary>
            [NameInMap("third_depart_pid")]
            [Validation(Required=false)]
            public string ThirdDepartPid { get; set; }

        }

    }

}
