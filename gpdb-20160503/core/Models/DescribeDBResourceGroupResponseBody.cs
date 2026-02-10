// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupItems")]
        [Validation(Required=false)]
        public DescribeDBResourceGroupResponseBodyResourceGroupItems ResourceGroupItems { get; set; }
        public class DescribeDBResourceGroupResponseBodyResourceGroupItems : TeaModel {
            [NameInMap("ResourceGroupItem")]
            [Validation(Required=false)]
            public List<DescribeDBResourceGroupResponseBodyResourceGroupItemsResourceGroupItem> ResourceGroupItem { get; set; }
            public class DescribeDBResourceGroupResponseBodyResourceGroupItemsResourceGroupItem : TeaModel {
                [NameInMap("ResourceGroupConfig")]
                [Validation(Required=false)]
                public string ResourceGroupConfig { get; set; }

                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

                [NameInMap("RoleList")]
                [Validation(Required=false)]
                public DescribeDBResourceGroupResponseBodyResourceGroupItemsResourceGroupItemRoleList RoleList { get; set; }
                public class DescribeDBResourceGroupResponseBodyResourceGroupItemsResourceGroupItemRoleList : TeaModel {
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public List<string> Role { get; set; }

                }

            }

        }

    }

}
