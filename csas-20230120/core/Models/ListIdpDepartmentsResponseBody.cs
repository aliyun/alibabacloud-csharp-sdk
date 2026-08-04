// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListIdpDepartmentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The department information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListIdpDepartmentsResponseBodyData Data { get; set; }
        public class ListIdpDepartmentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of department information.</para>
            /// </summary>
            [NameInMap("DataList")]
            [Validation(Required=false)]
            public List<ListIdpDepartmentsResponseBodyDataDataList> DataList { get; set; }
            public class ListIdpDepartmentsResponseBodyDataDataList : TeaModel {
                /// <summary>
                /// <para>The department ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30520</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The ID of the custom IdP configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1440</para>
                /// </summary>
                [NameInMap("IdpConfigId")]
                [Validation(Required=false)]
                public string IdpConfigId { get; set; }

                /// <summary>
                /// <para>The department name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例部门</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalNum")]
            [Validation(Required=false)]
            public long? TotalNum { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102350E7-1A20-58F5-9D63-ABEA820AE6E1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
