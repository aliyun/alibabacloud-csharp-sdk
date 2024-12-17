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

        /// <summary>
        /// <para>The whitelists of the instance.</para>
        /// </summary>
        [NameInMap("SecurityIpGroups")]
        [Validation(Required=false)]
        public DescribeSecurityIpsResponseBodySecurityIpGroups SecurityIpGroups { get; set; }
        public class DescribeSecurityIpsResponseBodySecurityIpGroups : TeaModel {
            [NameInMap("SecurityIpGroup")]
            [Validation(Required=false)]
            public List<DescribeSecurityIpsResponseBodySecurityIpGroupsSecurityIpGroup> SecurityIpGroup { get; set; }
            public class DescribeSecurityIpsResponseBodySecurityIpGroupsSecurityIpGroup : TeaModel {
                /// <summary>
                /// <para>The attribute of the whitelist. This parameter is empty by default.</para>
                /// <remarks>
                /// <para> If the instance is authorized to use a service such as Database Autonomy Service (DAS), Data Management (DMS), or Data Transmission Service (DTS), this service automatically generates a <b>hidden</b> whitelist for the instance. This type of whitelists cannot be modified or deleted.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>hidden</para>
                /// </summary>
                [NameInMap("SecurityIpGroupAttribute")]
                [Validation(Required=false)]
                public string SecurityIpGroupAttribute { get; set; }

                /// <summary>
                /// <para>The name of the whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("SecurityIpGroupName")]
                [Validation(Required=false)]
                public string SecurityIpGroupName { get; set; }

                /// <summary>
                /// <para>The IP addresses in the whitelist. A maximum of 1,000 IP addresses can be specified in a whitelist.</para>
                /// </summary>
                [NameInMap("SecurityIpList")]
                [Validation(Required=false)]
                public string SecurityIpList { get; set; }

            }

        }

    }

}
