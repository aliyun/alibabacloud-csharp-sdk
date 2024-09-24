// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class StartBaselineSecurityCheckRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the check items.</para>
        /// <remarks>
        /// <para>To perform a check task on cloud service configurations, you must specify the ID of the check item. You can call the <a href="~~DescribeRiskItemType~~">DescribeRiskItemType</a> operation to query the IDs of check items.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ItemIds")]
        [Validation(Required=false)]
        public List<long?> ItemIds { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
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

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>106.11.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The type of the check task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>check</b></description></item>
        /// <item><description><b>verify</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>verify</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
