// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class WhiteIpGroup : TeaModel {
        /// <summary>
        /// <para>The type of the IP address whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PRIVATE_ES: Elasticsearch private network access whitelist</description></item>
        /// <item><description>PUBLIC_ES: Elasticsearch public network access whitelist</description></item>
        /// <item><description>PRIVATE_KIBANA: Kibana private network access whitelist</description></item>
        /// <item><description>PUBLIC_KIBANA: Kibana public network access whitelist.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE_ES</para>
        /// </summary>
        [NameInMap("WhiteIpType")]
        [Validation(Required=false)]
        public string WhiteIpType { get; set; }

        /// <summary>
        /// <para>The name of the IP address whitelist group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_group</para>
        /// </summary>
        [NameInMap("groupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The list of IP addresses in the whitelist group.</para>
        /// </summary>
        [NameInMap("ips")]
        [Validation(Required=false)]
        public List<string> Ips { get; set; }

    }

}
