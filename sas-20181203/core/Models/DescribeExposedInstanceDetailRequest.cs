// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedInstanceDetailRequest : TeaModel {
        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
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
        /// <para>The Alibaba Cloud account ID of the member in the resource directory.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to query the account ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1232428423234****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The UUID of the server or the instance ID of the database that is exposed on the Internet.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeExposedInstanceList~~">DescribeExposedInstanceList</a> operation to query the UUIDs of servers or instance IDs of databases.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fc82b966-4d70-4e01-bf4f-aa4076a5****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
