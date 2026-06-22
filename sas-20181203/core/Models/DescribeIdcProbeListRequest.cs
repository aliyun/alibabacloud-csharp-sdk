// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeIdcProbeListRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the page to return. Default value: 1, which indicates that the first page is returned.</para>
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
        /// <para>The maximum number of entries per page when paging. Default value: 20. If you leave this parameter empty, 20 entries are returned per page.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The usage status of the probe. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: enabled</description></item>
        /// <item><description><b>1</b>: disabled.</description></item>
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
