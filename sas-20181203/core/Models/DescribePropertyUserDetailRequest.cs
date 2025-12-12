// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyUserDetailRequest : TeaModel {
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
        /// <para>Specifies whether the fuzzy search by account name is supported. If you want to use fuzzy search, set the parameter to <b>1</b>. If you set the parameter to a different value or leave the parameter empty, fuzzy search is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Extend")]
        [Validation(Required=false)]
        public string Extend { get; set; }

        /// <summary>
        /// <para>Specifies whether the account has root permissions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsRoot")]
        [Validation(Required=false)]
        public string IsRoot { get; set; }

        /// <summary>
        /// <para>The timestamp of the last logoff from the account. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>164922523600</para>
        /// </summary>
        [NameInMap("LastLoginTimeEnd")]
        [Validation(Required=false)]
        public long? LastLoginTimeEnd { get; set; }

        /// <summary>
        /// <para>The timestamp of the last logon to the account. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>164922523600</para>
        /// </summary>
        [NameInMap("LastLoginTimeStart")]
        [Validation(Required=false)]
        public long? LastLoginTimeStart { get; set; }

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

        [NameInMap("UseNextToken")]
        [Validation(Required=false)]
        public bool? UseNextToken { get; set; }

        /// <summary>
        /// <para>The name of the account to which the server belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bin</para>
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
