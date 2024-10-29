// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetClientUserResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetClientUserResponseBodyData Data { get; set; }
        public class GetClientUserResponseBodyData : TeaModel {
            [NameInMap("Department")]
            [Validation(Required=false)]
            public GetClientUserResponseBodyDataDepartment Department { get; set; }
            public class GetClientUserResponseBodyDataDepartment : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>107</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10713</para>
            /// </summary>
            [NameInMap("DepartmentId")]
            [Validation(Required=false)]
            public string DepartmentId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:johndoe@example.com">johndoe@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>83</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>598</para>
            /// </summary>
            [NameInMap("IdpConfigId")]
            [Validation(Required=false)]
            public string IdpConfigId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13641966835</para>
            /// </summary>
            [NameInMap("MobileNumber")]
            [Validation(Required=false)]
            public string MobileNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Disabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>su_abcd7215****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
