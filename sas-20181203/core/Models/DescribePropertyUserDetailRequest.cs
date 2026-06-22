// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyUserDetailRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the page to return in a paginated query. Default value: <b>1</b>, which indicates the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether fuzzy match is supported for account names. Set this parameter to <b>1</b> to enable fuzzy match. Any other value or an empty value indicates that fuzzy match is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>Specifies whether the account to query has ROOT permissions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No.</description></item>
        /// <item><description><b>1</b>: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsRoot")]
        [Validation(Required=false)]
        public string IsRoot { get; set; }

        /// <summary>
        /// <para>The end timestamp for querying the last logon time of the account. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1651298836000</para>
        /// </summary>
        [NameInMap("LastLoginTimeEnd")]
        [Validation(Required=false)]
        public long? LastLoginTimeEnd { get; set; }

        /// <summary>
        /// <para>The start timestamp for querying the last logon time of the account. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>164922523600</para>
        /// </summary>
        [NameInMap("LastLoginTimeStart")]
        [Validation(Required=false)]
        public long? LastLoginTimeStart { get; set; }

        /// <summary>
        /// <para>The token that marks the current position from which to start reading. Leave this parameter empty to start from the beginning.</para>
        /// <remarks>
        /// <para>Do not specify this parameter for the first call. The response includes the NextToken value for the second call. Each subsequent response contains the NextToken value for the next call.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>E17B501887A2D3AA5E8360A6EFA3B***</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of account asset fingerprint entries per page in a paging query. Default value: <b>10</b>, which indicates 10 account asset fingerprint entries per page.</para>
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
        /// <para>Specifies whether to use the NextToken method to retrieve the vulnerability list data. If this parameter is used, TotalCount is no longer returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Uses the NextToken method.</description></item>
        /// <item><description><b>false</b>: Does not use the NextToken method.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseNextToken")]
        [Validation(Required=false)]
        public bool? UseNextToken { get; set; }

        /// <summary>
        /// <para>The account name on the server to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bin</para>
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
