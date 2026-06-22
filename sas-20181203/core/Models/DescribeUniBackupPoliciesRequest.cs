// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUniBackupPoliciesRequest : TeaModel {
        /// <summary>
        /// <para>The page number from which to start displaying query results. Default value: <b>1</b>, which indicates that query results are displayed starting from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to display per page for a paginated query. The default number of entries per page is 20. If the PageSize parameter is left empty, 20 entries are returned by default.</para>
        /// <remarks>
        /// <para>We recommend that you do not leave PageSize empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the database anti-ransomware backup policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto_oracle_Hpm</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

    }

}
