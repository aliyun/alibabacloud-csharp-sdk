// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class DescribeSimilarSecurityEventsRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the returned results. Default value: <b>1</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return in a single query. This parameter is reserved for compatibility. The backend currently uses CurrentPage and PageSize for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to start the query. You can obtain the token from the result of the previous request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>****==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The Settings for the number of alerting events displayed on each page in a paged query. Default value: <b>20</b>, which indicates that 20 alerting events are displayed per paging.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the query task. You can call the <a href="~~CreateSimilarSecurityEventsQueryTask~~">CreateSimilarSecurityEventsQueryTask</a> operation to obtain this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1689135</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
