// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAccountMaskingPrivilegeResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAccountMaskingPrivilegeResponseBodyData Data { get; set; }
        public class DescribeAccountMaskingPrivilegeResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of user encryption or data masking permissions.</para>
            /// </summary>
            [NameInMap("UserPrivilege")]
            [Validation(Required=false)]
            public List<DescribeAccountMaskingPrivilegeResponseBodyDataUserPrivilege> UserPrivilege { get; set; }
            public class DescribeAccountMaskingPrivilegeResponseBodyDataUserPrivilege : TeaModel {
                /// <summary>
                /// <para>The permission expiration time in UTC format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-22T02:01:20Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The permission type. The value restrictedAccess indicates restricted access (data masking required).</para>
                /// 
                /// <b>Example:</b>
                /// <para>restrictedAccess</para>
                /// </summary>
                [NameInMap("Privilege")]
                [Validation(Required=false)]
                public string Privilege { get; set; }

                /// <summary>
                /// <para>The account name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rds</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D0073A98-52F1-3075-8256-394**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
