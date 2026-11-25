// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class ListAppConversationsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the bot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Zero2</para>
        /// </summary>
        [NameInMap("BotId")]
        [Validation(Required=false)]
        public string BotId { get; set; }

        /// <summary>
        /// <para>The end time for the modification in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20201212</para>
        /// </summary>
        [NameInMap("EndModifyTime")]
        [Validation(Required=false)]
        public string EndModifyTime { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return for a single query. Valid values: 10 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to start the next query. If there is no next query, this parameter is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0l45bkwM022Dt+rOvPi/oQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of items per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1168642640022064</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public string SiteId { get; set; }

        /// <summary>
        /// <para>The start time for the modification in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20200101</para>
        /// </summary>
        [NameInMap("StartModifyTime")]
        [Validation(Required=false)]
        public string StartModifyTime { get; set; }

    }

}
