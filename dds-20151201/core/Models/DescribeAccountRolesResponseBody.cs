// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeAccountRolesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7FEF1BEF-2842-5758-9126-415A297*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Roles")]
        [Validation(Required=false)]
        public DescribeAccountRolesResponseBodyRoles Roles { get; set; }
        public class DescribeAccountRolesResponseBodyRoles : TeaModel {
            [NameInMap("Role")]
            [Validation(Required=false)]
            public List<DescribeAccountRolesResponseBodyRolesRole> Role { get; set; }
            public class DescribeAccountRolesResponseBodyRolesRole : TeaModel {
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

        }

    }

}
