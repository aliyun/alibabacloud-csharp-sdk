// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ListRLTrajectoriesRequest : TeaModel {
        /// <summary>
        /// <para>The end time of the query window in UTC RFC3339 format. Default value: now.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-07T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1. This parameter must be provided together with PageSize. If neither is provided, the default values PageNumber=1 and PageSize=10 are used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 1000. This parameter must be provided together with PageNumber. If neither is provided, the default value 10 is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sample UID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3afcfbdf-3956-4ab2-b9cb-f9c204b8fc9c</para>
        /// </summary>
        [NameInMap("PromptUid")]
        [Validation(Required=false)]
        public string PromptUid { get; set; }

        /// <summary>
        /// <para>The start time of the query window in UTC RFC3339 format. Default value: EndTime-7d.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-04T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
