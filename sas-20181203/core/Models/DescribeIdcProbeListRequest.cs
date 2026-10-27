// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeIdcProbeListRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the page number of the page to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the IDC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3K IDC</para>
        /// </summary>
        [NameInMap("IdcName")]
        [Validation(Required=false)]
        public string IdcName { get; set; }

        /// <summary>
        /// <para>Specifies the maximum number of entries to return on each page for a paging query. The default number of entries per page is 20. If the PageSize parameter is left empty, 20 entries are returned by default.</para>
        /// <remarks>
        /// <para>Specify a value for the PageSize parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The status of the probe. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Enabled.</description></item>
        /// <item><description><b>1</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
