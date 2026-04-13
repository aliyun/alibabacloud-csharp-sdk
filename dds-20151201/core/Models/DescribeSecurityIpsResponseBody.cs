// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeSecurityIpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC724D23-2962-479E-ABB1-606C935AE7FD</para>
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

        /// <summary>
        /// <para>The IP addresses in the default whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47.xxx.xxx.xx,100.xxx.xxx.0/24</para>
        /// </summary>
        [NameInMap("SecurityIps")]
        [Validation(Required=false)]
        public string SecurityIps { get; set; }

    }

}
