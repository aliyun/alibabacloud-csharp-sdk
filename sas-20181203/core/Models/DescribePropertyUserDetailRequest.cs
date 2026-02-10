// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyUserDetailRequest : TeaModel {
        /// <summary>
        /// <para>Set which page of the returned results to start displaying the query results. The default value is <b>1</b>, indicating that the display starts from the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Whether the account name supports fuzzy search. To enable fuzzy search, set this parameter\&quot;s value to <b>1</b>; other values or an empty value indicate that fuzzy search is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>Whether the queried account has ROOT privileges. Possible values include:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: No</description></item>
        /// <item><description><b>1</b>: Yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsRoot")]
        [Validation(Required=false)]
        public string IsRoot { get; set; }

        /// <summary>
        /// <para>The end timestamp for the last login retrieval. The unit is milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1651298836000</para>
        /// </summary>
        [NameInMap("LastLoginTimeEnd")]
        [Validation(Required=false)]
        public long? LastLoginTimeEnd { get; set; }

        /// <summary>
        /// <para>The start timestamp for the last login retrieval. The unit is milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>164922523600</para>
        /// </summary>
        [NameInMap("LastLoginTimeStart")]
        [Validation(Required=false)]
        public long? LastLoginTimeStart { get; set; }

        /// <summary>
        /// <para>Used to mark the starting position for reading. Leave it empty to start from the beginning.</para>
        /// <remarks>
        /// <para>For the first call, you do not need to fill in this field. The response will include the NextToken for the second call, and each subsequent call will include the NextToken for the next call.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>E17B501887A2D3AA5E8360A6EFA3B***</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Set the number of account asset fingerprint information items to display per page during pagination. The default value is <b>10</b>, indicating that 10 items of account asset fingerprint information are displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name or IP address of the server to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>Whether to use the NextToken method to fetch vulnerability list data. If this parameter is used, TotalCount will no longer be returned. Possible values:</para>
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
        /// <para>The account name of the server to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bin</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        /// <summary>
        /// <para>The UUID of the server to be queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50d213b4-3a35-427a-b8a5-04b0c7e1****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
