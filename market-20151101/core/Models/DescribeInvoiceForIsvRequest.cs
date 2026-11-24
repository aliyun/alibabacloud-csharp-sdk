// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeInvoiceForIsvRequest : TeaModel {
        /// <summary>
        /// <para>The end time. By default, 23:59:59 is appended to the date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// <para>The start time. By default, 00:00:00 is appended to the date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-31 23:59:59</para>
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        /// <summary>
        /// <para>The ID of the invoice application. This corresponds to the Result.Id field in the response of the DescribeInvoiceForIsv operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4072040****</para>
        /// </summary>
        [NameInMap("InvoiceId")]
        [Validation(Required=false)]
        public long? InvoiceId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paging query. Maximum value: 50. Default value: 10. (This parameter is not enabled.)</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token returned by the current call. This parameter is not enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3v3mzZN1QdVsTPNiT0OkD9v+MeV8LSqSQDSuTTVFCUMMWShmnj/LXRMScqm242bB</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public long? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The current invoice status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Applying.</description></item>
        /// <item><description>1: Completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>The invoice type. If this parameter is left empty, all types are queried by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>2: Digital electronic ordinary invoice.</description></item>
        /// <item><description>3: Digital electronic special invoice.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud user ID of the customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>174452687724****</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
