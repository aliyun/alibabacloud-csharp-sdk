// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulListPageRequest : TeaModel {
        /// <summary>
        /// <para>The number of the current page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The CVE ID of the vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CVE-2022-44702</para>
        /// </summary>
        [NameInMap("CveId")]
        [Validation(Required=false)]
        public string CveId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to display per page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether runtime application self-protection (RASP) is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not supported.</description></item>
        /// <item><description><b>1</b>: Supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RaspDefend")]
        [Validation(Required=false)]
        public int? RaspDefend { get; set; }

        /// <summary>
        /// <para>The name of the vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Remote code execute vulnerability</para>
        /// </summary>
        [NameInMap("VulNameLike")]
        [Validation(Required=false)]
        public string VulNameLike { get; set; }

        /// <summary>
        /// <para>The type of vulnerability to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cve: Linux software vulnerability</description></item>
        /// <item><description>sys: Windows system vulnerability</description></item>
        /// <item><description>app: application vulnerability</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("VulType")]
        [Validation(Required=false)]
        public string VulType { get; set; }

    }

}
