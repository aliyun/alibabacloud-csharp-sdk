// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20210202.Models
{
    public class ListAuthRolesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>8E2C1BB9-57C4-5051-9EF2-570ADC03A164</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Roles")]
        [Validation(Required=false)]
        public List<ListAuthRolesResponseBodyRoles> Roles { get; set; }
        public class ListAuthRolesResponseBodyRoles : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsEnabled")]
            [Validation(Required=false)]
            public string IsEnabled { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:ram::1557********904:role/aliyunodpspaidefaultrole</para>
            /// </summary>
            [NameInMap("RoleARN")]
            [Validation(Required=false)]
            public string RoleARN { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AliyunODPSPAIDefaultRole</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PaiStudio。</para>
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            [NameInMap("Token")]
            [Validation(Required=false)]
            public ListAuthRolesResponseBodyRolesToken Token { get; set; }
            public class ListAuthRolesResponseBodyRolesToken : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>STS.NU************TT5LoC</para>
                /// </summary>
                [NameInMap("AccessKeyId")]
                [Validation(Required=false)]
                public string AccessKeyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>E1h2n66Duo1D**********c79JVk59R6i</para>
                /// </summary>
                [NameInMap("AccessKeySecret")]
                [Validation(Required=false)]
                public string AccessKeySecret { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-03-19T19:14:42Z</para>
                /// </summary>
                [NameInMap("Expiration")]
                [Validation(Required=false)]
                public string Expiration { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CAISggJ1q6Ft5B2yf***************aAaDf+bmceH2MNtNe9XtmTXJytadQ2T0RT8uOA+4kSypOPxSHjdjmnQjbdA/Q9MyNtTErQ/m45RNsg==</para>
                /// </summary>
                [NameInMap("SecurityToken")]
                [Validation(Required=false)]
                public string SecurityToken { get; set; }

            }

        }

    }

}
