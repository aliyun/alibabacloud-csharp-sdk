// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyScaProcessDetailRequest : TeaModel {
        /// <summary>
        /// <para>The type of the application process. Default value: <b>java</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>java</b>: Java process.</description></item>
        /// <item><description><b>php</b>: PHP process.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>java</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// <para>The startup parameter.</para>
        /// <remarks>
        /// <para> This parameter supports only prefix queries. Fuzzy match is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>java -jar</para>
        /// </summary>
        [NameInMap("Cmdline")]
        [Validation(Required=false)]
        public string Cmdline { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. If you leave this parameter empty, 10 entries are returned on each page.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The process ID.</para>
        /// <remarks>
        /// <para> Only exact match is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>756</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>The information about the server that you want to query. The value can be the public IP address, private IP address, or name of the server. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.167.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The UUID of the server.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the UUIDs of servers.</para>
        /// </description></item>
        /// <item><description><para>Only exact match is supported.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>D0D6E6E4-CB8C-4897-B852-46AEFDA0****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
