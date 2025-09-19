// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeWhiteListProcessRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: <b>1</b>. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The sort order. Default value: descending order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: ascending order</description></item>
        /// <item><description><b>2</b>: descending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public int? Desc { get; set; }

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
        /// <para>The item based on which you want to sort the returned results. Default value: <b>process type</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: process type</description></item>
        /// <item><description><b>2</b>: degree of trustability</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public int? OrderBy { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 1000. Default value: 20. If you leave this parameter empty, 20 data entries are returned per page.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JAVA</para>
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        /// <summary>
        /// <para>The type of the process. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: trusted</description></item>
        /// <item><description><b>2</b>: suspicious</description></item>
        /// <item><description><b>3</b>: malicious</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProcessType")]
        [Validation(Required=false)]
        public int? ProcessType { get; set; }

        /// <summary>
        /// <para>The source IP address of the request. You do not need to specify this parameter. It is automatically obtained by the system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27.223.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The ID of the policy.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeWhiteListStrategyList~~">DescribeWhiteListStrategyList</a> operation to obtain the ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8562</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

    }

}
