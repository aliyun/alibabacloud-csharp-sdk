// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDTCSecurityIpHostsForSQLServerResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The number of distributed transaction whitelists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IpHostPairNum")]
        [Validation(Required=false)]
        public string IpHostPairNum { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDTCSecurityIpHostsForSQLServerResponseBodyItems Items { get; set; }
        public class DescribeDTCSecurityIpHostsForSQLServerResponseBodyItems : TeaModel {
            [NameInMap("WhiteListGroups")]
            [Validation(Required=false)]
            public List<DescribeDTCSecurityIpHostsForSQLServerResponseBodyItemsWhiteListGroups> WhiteListGroups { get; set; }
            public class DescribeDTCSecurityIpHostsForSQLServerResponseBodyItemsWhiteListGroups : TeaModel {
                [NameInMap("SecurityIpHosts")]
                [Validation(Required=false)]
                public string SecurityIpHosts { get; set; }

                [NameInMap("WhitelistGroupName")]
                [Validation(Required=false)]
                public string WhitelistGroupName { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2CA62A70-2203-45C6-8E90-8971D5ACC0C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
