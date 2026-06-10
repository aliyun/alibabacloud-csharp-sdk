// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppConversationsRequest : TeaModel {
        /// <summary>
        /// <para>Bot ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zero2</para>
        /// </summary>
        [NameInMap("BotId")]
        [Validation(Required=false)]
        public string BotId { get; set; }

        /// <summary>
        /// <para>End modification time (ISO 8601 format)</para>
        /// 
        /// <b>Example:</b>
        /// <para>20201212</para>
        /// </summary>
        [NameInMap("EndModifyTime")]
        [Validation(Required=false)]
        public string EndModifyTime { get; set; }

        /// <summary>
        /// <para>The number of entries to return in each query result.  </para>
        /// <para>Valid values: 10 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Token indicating the start of the next query. It is empty when there is no next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0l45bkwM022Dt+rOvPi/oQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>Number of entries per page</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Site ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1168642640022064</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public string SiteId { get; set; }

        /// <summary>
        /// <para>Start modification time (ISO 8601 format)</para>
        /// 
        /// <b>Example:</b>
        /// <para>20200101</para>
        /// </summary>
        [NameInMap("StartModifyTime")]
        [Validation(Required=false)]
        public string StartModifyTime { get; set; }

    }

}
