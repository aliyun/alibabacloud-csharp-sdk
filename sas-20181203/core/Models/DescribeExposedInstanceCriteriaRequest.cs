// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedInstanceCriteriaRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the member account in the resource directory.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public string ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The value of the query condition. Fuzzy match is supported.</para>
        /// <remarks>
        /// <para>This parameter supports queries by asset name, asset ID, public IP address of the asset, private IP address of the asset, exposed component, exposed port, or exposed IP address.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testInstanceName</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
