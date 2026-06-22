// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckWarningDetailRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the check item.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListCheckItemWarningSummary~~">ListCheckItemWarningSummary</a> operation to obtain the check item ID.&gt;Notice: When this parameter is specified, the Uuid parameter is required..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public string CheckId { get; set; }

        /// <summary>
        /// <para>The alert ID of the check item.</para>
        /// <remarks>
        /// <para>To query the details of a specified check item, provide the alert ID of the check item. You can call the <a href="~~DescribeCheckWarnings~~">DescribeCheckWarnings</a> operation to obtain this ID.
        /// Notice: This parameter is required when both Uuid and CheckId are empty..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>98675301</para>
        /// </summary>
        [NameInMap("CheckWarningId")]
        [Validation(Required=false)]
        public long? CheckWarningId { get; set; }

        /// <summary>
        /// <para>The container name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_container</para>
        /// </summary>
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account of the member accounts in the resource folder.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16670360956*****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>103.25.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The UUID of the server to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to obtain this parameter.&gt;Notice: When this parameter is specified, the CheckId parameter is required..</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>06125d19-6a02-4451-9f65-2083996e****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
