// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyCronDetailRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the results to return. Default value: <b>1</b>, which indicates that the results start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether fuzzy match is supported for the scheduled task path. Set this parameter to <b>1</b> to enable fuzzy match. Other values or an empty value indicate that fuzzy match is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The token that marks the current position from which to start reading. Leave this parameter empty to start reading from the beginning.</para>
        /// <remarks>
        /// <para>You do not need to specify this parameter for the first call. The response includes the NextToken value for the second call. Each subsequent response includes the NextToken value for the next call.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1426C575705AE8545E8360A6EFA3B***</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Settings the number of entries per page in a paging query. Default value: <b>10</b>, which indicates that 10 fingerprint entries of scheduled task assets are displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name or IP address of the server to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member accounts in the resource folder.</para>
        /// <remarks>
        /// <para>Invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The path of the scheduled task to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/etc/cron.d/root</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the NextToken method to retrieve the vulnerability list data. If you use this parameter, TotalCount is no longer returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Use the NextToken method.</description></item>
        /// <item><description><b>false</b>: Do not use the NextToken method.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseNextToken")]
        [Validation(Required=false)]
        public bool? UseNextToken { get; set; }

        /// <summary>
        /// <para>The account name of the scheduled task to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        /// <summary>
        /// <para>The UUID of the server to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50d213b4-3a35-427a-b8a5-04b0c7e1****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
