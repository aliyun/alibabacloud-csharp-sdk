// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAddressBookRequest : TeaModel {
        /// <summary>
        /// <para>The port that is included in the address book. This parameter takes effect only when the <b>GroupType</b> parameter is set to <b>port</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ContainPort")]
        [Validation(Required=false)]
        public string ContainPort { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The type of the address book. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ip</b>: IP address book</description></item>
        /// <item><description><b>domain</b>: domain address book</description></item>
        /// <item><description><b>port</b>: port address book</description></item>
        /// <item><description><b>tag</b>: Elastic Compute Service (ECS) tag-based address book</description></item>
        /// <item><description><b>allCloud</b>: cloud service address book</description></item>
        /// <item><description><b>threat</b>: threat intelligence address book</description></item>
        /// <item><description><b>ipv6</b>: IPv6 address book<remarks>
        /// <para> If you do not specify a type, the domain address books and ECS tag-based address books are queried.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ip</para>
        /// </summary>
        [NameInMap("GroupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The language of the content within the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Default value: 10. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The query condition that is used to search for the address book.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
