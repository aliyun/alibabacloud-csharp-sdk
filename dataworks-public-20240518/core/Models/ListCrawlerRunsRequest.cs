// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListCrawlerRunsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the metadata crawler. You can call ListCrawlers to obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The lower bound of the run start time, in millisecond-level UNIX timestamp. The value must be within the last 30 days. If not specified, the default value is 30 days before the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710239005403</para>
        /// </summary>
        [NameInMap("StartTimeFrom")]
        [Validation(Required=false)]
        public long? StartTimeFrom { get; set; }

        /// <summary>
        /// <para>The upper bound of the run start time, in millisecond-level UNIX timestamp. The value must be within the last 30 days. If not specified, the default value is the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1710325405403</para>
        /// </summary>
        [NameInMap("StartTimeTo")]
        [Validation(Required=false)]
        public long? StartTimeTo { get; set; }

        /// <summary>
        /// <para>The run status. Valid values: WAITING, RUNNING, SUCCESS, ERROR, SHUTDOWN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
