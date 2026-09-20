// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListBaselineStatusesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the baseline. Valid values: DAILY and HOURLY. Separate multiple values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAILY,HOURLY</para>
        /// </summary>
        [NameInMap("BaselineTypes")]
        [Validation(Required=false)]
        public string BaselineTypes { get; set; }

        /// <summary>
        /// <para>The business date in UTC format (yyyy-MM-dd\&quot;T\&quot;HH:mm:ssZ).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-07-07T00:00:00+0800</para>
        /// </summary>
        [NameInMap("Bizdate")]
        [Validation(Required=false)]
        public string Bizdate { get; set; }

        /// <summary>
        /// <para>The completion status of the baseline instance. Valid values: UNFINISH and FINISH. Separate multiple values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>FINISH,UNFINISH</para>
        /// </summary>
        [NameInMap("FinishStatus")]
        [Validation(Required=false)]
        public string FinishStatus { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud UID of the baseline owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9527952795****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1. Minimum value: 1. Maximum value: 30.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The priority of the baseline. Valid values: 1, 3, 5, 7, and 8. Separate multiple priorities with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,3,5,7,8</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The search keyword. You can search by baseline name or baseline ID. If you enter an hourly baseline ID, all instances of that hourly baseline are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>keyword</para>
        /// </summary>
        [NameInMap("SearchText")]
        [Validation(Required=false)]
        public string SearchText { get; set; }

        /// <summary>
        /// <para>The status of the baseline. Valid values: ERROR, SAFE, DANGROUS, and OVER. Separate multiple values with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>SAFE,DANGROUS,OVER</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the related event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("TopicId")]
        [Validation(Required=false)]
        public long? TopicId { get; set; }

    }

}
