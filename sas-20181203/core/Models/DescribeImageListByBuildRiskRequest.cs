// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageListByBuildRiskRequest : TeaModel {
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
        /// <para>The language of the content within the request and response. Valid values:</para>
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
        /// <para>The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.</para>
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
        /// <para>The key of the risk. You can call the <a href="~~~~">DescribeImageBuildRiskList</a> operation to obtain the value of RiskKey.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no_user</para>
        /// </summary>
        [NameInMap("RiskKey")]
        [Validation(Required=false)]
        public string RiskKey { get; set; }

        /// <summary>
        /// <para>The risk level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>high</b></description></item>
        /// <item><description><b>medium</b></description></item>
        /// <item><description><b>low</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>The status of the alert event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: unhandled.</description></item>
        /// <item><description><b>1</b>: ignored.</description></item>
        /// <item><description><b>2</b>: false positive.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
