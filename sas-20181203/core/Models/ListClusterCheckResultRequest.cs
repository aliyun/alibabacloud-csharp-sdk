// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClusterCheckResultRequest : TeaModel {
        /// <summary>
        /// <para>Fuzzy search key for check items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>container</para>
        /// </summary>
        [NameInMap("CheckKey")]
        [Validation(Required=false)]
        public string CheckKey { get; set; }

        /// <summary>
        /// <para>Cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c3aaf6c8085f84791882eef200cd2****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Page number for the current page in a paginated query. The default value is <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Language type for requests and responses. The default value is <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Number of records to display per page when performing a paginated query. The default value is <b>20</b>, indicating 20 records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>List of risk levels.</para>
        /// </summary>
        [NameInMap("RiskLevels")]
        [Validation(Required=false)]
        public List<string> RiskLevels { get; set; }

        /// <summary>
        /// <para>Custom sorting type. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>RISK_LEVEL</b>: Risk level.</description></item>
        /// <item><description><b>STATUS</b>: Check item status.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>STATUS</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// <para>List of check item statuses.</para>
        /// </summary>
        [NameInMap("Statuses")]
        [Validation(Required=false)]
        public List<string> Statuses { get; set; }

    }

}
