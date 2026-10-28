// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListProductQuotaDimensionsRequest : Darabonba.Model {
        /// <summary>
        /// <para>The maximum number of entries to return for this query.</para>
        /// <para>Valid values: 1 to 200. Default value: 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that specifies the starting position of the query. If you leave this parameter empty, the query starts from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The abbreviated name of the cloud service.</para>
        /// <remarks>
        /// <para>For more information about how to obtain the abbreviated name of a cloud service, see <c>ProductCode</c> in <a href="https://help.aliyun.com/document_detail/440555.html">ListProducts</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>disk</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The quota category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>FlowControl: API rate limits.</para>
        /// </description></item>
        /// <item><description><para>CommonQuota: general quotas. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Privileges (WhiteListLabel) do not have quota dimensions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CommonQuota</para>
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

    }

}

