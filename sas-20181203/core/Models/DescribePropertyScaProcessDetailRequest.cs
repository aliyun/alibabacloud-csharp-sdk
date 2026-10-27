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
        /// <item><description><b>java</b>: Java process</description></item>
        /// <item><description><b>php</b>: PHP process</description></item>
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
        /// <para>Only prefix match is supported. Fuzzy match is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>java -jar</para>
        /// </summary>
        [NameInMap("Cmdline")]
        [Validation(Required=false)]
        public string Cmdline { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page in a paged query. The default number of entries per page for paging is 10. If this parameter is left empty, 10 entries are returned by default.</para>
        /// <remarks>
        /// <para>Specify a value for this parameter.</para>
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
        /// <para>Only exact match is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>756</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>The asset information to query. You can set this parameter to the asset name, public IP address, or private IP address. Fuzzy match is supported.</para>
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
        /// <list type="bullet">
        /// <item><description>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to obtain this parameter.</description></item>
        /// <item><description>Only exact match is supported.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>D0D6E6E4-CB8C-4897-B852-46AEFDA0****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
