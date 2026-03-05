// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeSecurityIpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EFC9161F-15E3-4A6E-8A99-C09916D1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityIpGroups")]
        [Validation(Required=false)]
        public DescribeSecurityIpsResponseBodySecurityIpGroups SecurityIpGroups { get; set; }
        public class DescribeSecurityIpsResponseBodySecurityIpGroups : TeaModel {
            [NameInMap("SecurityIpGroup")]
            [Validation(Required=false)]
            public List<DescribeSecurityIpsResponseBodySecurityIpGroupsSecurityIpGroup> SecurityIpGroup { get; set; }
            public class DescribeSecurityIpsResponseBodySecurityIpGroupsSecurityIpGroup : TeaModel {
                [NameInMap("SecurityIpGroupAttribute")]
                [Validation(Required=false)]
                public string SecurityIpGroupAttribute { get; set; }

                [NameInMap("SecurityIpGroupName")]
                [Validation(Required=false)]
                public string SecurityIpGroupName { get; set; }

                [NameInMap("SecurityIpList")]
                [Validation(Required=false)]
                public string SecurityIpList { get; set; }

            }

        }

    }

}
