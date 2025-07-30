// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CioMarketPop20250709.Models
{
    public class GetEveryOneSellsFormListResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<GetEveryOneSellsFormListResponseBody> Body { get; set; }
        public class GetEveryOneSellsFormListResponseBody : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>virtualMainDepartment</para>
            /// </summary>
            [NameInMap("VirtualMainDepartment")]
            [Validation(Required=false)]
            public string VirtualMainDepartment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>virtualDepartmentName</para>
            /// </summary>
            [NameInMap("VirtualDepartmentName")]
            [Validation(Required=false)]
            public string VirtualDepartmentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>virtualDepartmentCode</para>
            /// </summary>
            [NameInMap("VirtualDepartmentCode")]
            [Validation(Required=false)]
            public string VirtualDepartmentCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>virtualParentDepartment</para>
            /// </summary>
            [NameInMap("VirtualParentDepartment")]
            [Validation(Required=false)]
            public string VirtualParentDepartment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>virtualDepartmentStatus</para>
            /// </summary>
            [NameInMap("VirtualDepartmentStatus")]
            [Validation(Required=false)]
            public string VirtualDepartmentStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("DingId")]
            [Validation(Required=false)]
            public string DingId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>work</para>
            /// </summary>
            [NameInMap("EmpStatus")]
            [Validation(Required=false)]
            public string EmpStatus { get; set; }

        }

    }

}
