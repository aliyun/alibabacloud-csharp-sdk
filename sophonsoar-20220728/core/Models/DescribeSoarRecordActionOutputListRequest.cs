// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSoarRecordActionOutputListRequest : TeaModel {
        /// <summary>
        /// <para>The UUID of the component action.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeSoarTaskAndActions~~">DescribeSoarTaskAndActions</a> operation to get this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2202c90d-fa93-4726-bc32-xxxxxx</para>
        /// </summary>
        [NameInMap("ActionUuid")]
        [Validation(Required=false)]
        public string ActionUuid { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The page number of the results to return. Default value: 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 10 entries are returned.</para>
        /// <remarks>
        /// <para>We recommend that you specify a value for this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
