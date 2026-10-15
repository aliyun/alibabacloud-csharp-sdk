// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class GetWorksEmbedListRequest : TeaModel {
        /// <summary>
        /// <para>The report name for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test dataset</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The report type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>page: dashboard.</description></item>
        /// <item><description>screen: data screen.</description></item>
        /// <item><description>report: workbook.</description></item>
        /// <item><description>ANALYSIS: ad hoc analysis.</description></item>
        /// <item><description>dashboardOfflineQuery: self-service data retrieval.</description></item>
        /// <item><description>dataForm: data entry form.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>page</para>
        /// </summary>
        [NameInMap("WorksType")]
        [Validation(Required=false)]
        public string WorksType { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>919818-<em><b>-</b></em>**-wdasd</para>
        /// </summary>
        [NameInMap("WsId")]
        [Validation(Required=false)]
        public string WsId { get; set; }

    }

}
