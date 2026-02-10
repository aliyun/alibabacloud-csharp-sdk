// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyCronDetailRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether fuzzy search by path to the scheduled task is supported. If you want to use fuzzy search, set the parameter to <b>1</b>. If you set the parameter to a different value or leave the parameter empty, fuzzy search is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>The value of NextToken that is returned when the NextToken method is used. You do not need to specify this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1426C575705AE8545E8360A6EFA3B***</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name or IP address of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The path to the scheduled task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/etc/cron.d/root</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the NextToken method to retrieve a new page of results. If you set UseNextToken to true, the value of TotalCount is not returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The NextToken method is used.</description></item>
        /// <item><description><b>false</b>: The NextToken method is not used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseNextToken")]
        [Validation(Required=false)]
        public bool? UseNextToken { get; set; }

        /// <summary>
        /// <para>The username of the account that runs the scheduled task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>root</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        /// <summary>
        /// <para>The UUID of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50d213b4-3a35-427a-b8a5-04b0c7e1****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
