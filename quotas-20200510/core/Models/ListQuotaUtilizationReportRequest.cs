// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quotas20200510.Models
{
    public class ListQuotaUtilizationReportRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to filter quotas by adjustability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Queries only adjustable quotas.</description></item>
        /// <item><description>false: Queries only non-adjustable quotas.
        /// If this parameter is not specified, quotas are not filtered by adjustability.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Adjustable")]
        [Validation(Required=false)]
        public bool? Adjustable { get; set; }

        /// <summary>
        /// <para>The search keyword. Performs a fuzzy match based on the quota name or quota ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("KeyWords")]
        [Validation(Required=false)]
        public string KeyWords { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return for this query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Do not specify this parameter for the first query. For subsequent queries, pass the NextToken value returned in the previous response as is, and keep the quota type and filter conditions unchanged. Do not parse or construct the token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJvZmZzZXQiOjEwLCJvdHNOZXh0VG9rZW4iOiJDQUVTR3dvWkNoY0tFM1J2ZEdGc1gzVnpZV2RsWDNCbGNtTmxiblFRQVJnQkl1RUJDZ2tCQUFBQUFBQUFXVUFLMHdFRHpnQUFBREZUTXpFek9ETXdNemN6TnpNNE16VXpPVE0xTXpjek5qTXpNekV6TlRNNE16Z3VVek01TXpjek5UTTJOalkyTWpZeE16Y3laRFl5TmpJek16WXhNbVF6TkRNMk16RXpOREprTmpFek9UTTRNemN5WkRZMk16WTJORE16TXpVMk16TXhNemt6TURZMk16RXpNUzVUTmpFMk16YzBOamsyWmpabE56UTNNall4TmprMll5NVRNelkyTWpZMU16a3pPRE0yTmpRek1qSmtNekV6TlRNeU5qRXlaRE0wTXpFek1UWTJNbVEyTWpZME16TXpNVEprTXpNMk16WXlOalV6TkRNMU16VXpNalkwTXpVek1qTTMiLCJ0YXNrSWQiOiI5NzU2ZmJhNy1iYjNhLTQ2MTQtYTk4Ny1mNmQzNWMxOTBmMTEiLCJ1aWQiOiIxODA3Nzg1OTU3NjMxNTg4IiwidXRpbGl6YXRpb25TdGF0dXNlcyI6IiJ9</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The abbreviation of the cloud service.</para>
        /// <remarks>
        /// <para>For information about how to obtain the abbreviation of a cloud service, see ProductCode in <a href="https://help.aliyun.com/document_detail/440555.html">ListProducts</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>CommonQuota, FlowControl</para>
        /// 
        /// <b>Example:</b>
        /// <para>CommonQuota</para>
        /// </summary>
        [NameInMap("QuotaCategory")]
        [Validation(Required=false)]
        public string QuotaCategory { get; set; }

        /// <summary>
        /// <para>The region ID of the quota, such as cn-hangzhou. If this parameter is not specified or is left empty, quotas are not filtered by region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("QuotaRegionId")]
        [Validation(Required=false)]
        public string QuotaRegionId { get; set; }

        /// <summary>
        /// <para>The utilization statuses. You can specify multiple values. If this parameter is not specified or an empty list is passed, quotas are not filtered by utilization status.</para>
        /// </summary>
        [NameInMap("UtilizationStatuses")]
        [Validation(Required=false)]
        public List<string> UtilizationStatuses { get; set; }

    }

}
