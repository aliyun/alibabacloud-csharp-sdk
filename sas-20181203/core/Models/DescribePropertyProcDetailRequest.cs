// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyProcDetailRequest : TeaModel {
        /// <summary>
        /// <para>The startup parameters of the process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>./8888</para>
        /// </summary>
        [NameInMap("Cmdline")]
        [Validation(Required=false)]
        public string Cmdline { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: <b>1</b>, which indicates that the first page is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether fuzzy match is supported for the process name. Set this parameter to 1 to enable fuzzy match. Other values or an empty value indicate that fuzzy match is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The process name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8888</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The token that marks the current position from which to start reading. Leave this parameter empty to start reading from the beginning.</para>
        /// <remarks>
        /// <para>You do not need to specify this parameter for the first call. The NextToken value for the second call is included in the response of the first call. Each subsequent response contains the NextToken value for the next call.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6k+AtdhNE3kgQEK36GujZ5on+tWdc+4WoaoMP/kUNxxxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Default value: <b>10</b>, which indicates that 10 entries of process Asset Fingerprints information are displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The end timestamp of the process startup time range. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649587453000</para>
        /// </summary>
        [NameInMap("ProcTimeEnd")]
        [Validation(Required=false)]
        public long? ProcTimeEnd { get; set; }

        /// <summary>
        /// <para>The start timestamp of the process startup time range. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1648809853000</para>
        /// </summary>
        [NameInMap("ProcTimeStart")]
        [Validation(Required=false)]
        public long? ProcTimeStart { get; set; }

        /// <summary>
        /// <para>The name or IP address of the server that you want to query.</para>
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
        /// <para>You can invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the NextToken method to retrieve the vulnerability list data. If this parameter is used, TotalCount is no longer returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Use the NextToken method.</description></item>
        /// <item><description><b>false</b>: Do not use the NextToken method.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseNextToken")]
        [Validation(Required=false)]
        public bool? UseNextToken { get; set; }

        /// <summary>
        /// <para>The information about the user that runs the process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        /// <summary>
        /// <para>The UUID of the server that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50d213b4-3a35-427a-b8a5-04b0c7e1****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
