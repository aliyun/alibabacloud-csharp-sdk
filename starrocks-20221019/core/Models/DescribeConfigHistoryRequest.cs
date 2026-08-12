// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class DescribeConfigHistoryRequest : TeaModel {
        /// <summary>
        /// <para>Filters the results by the effective status of the configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>effective</para>
        /// </summary>
        [NameInMap("EffectStatuses")]
        [Validation(Required=false)]
        public string EffectStatuses { get; set; }

        /// <summary>
        /// <para>The end time for the query, specified as a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1742178604000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-b25e21e24388****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the total number of configuration history records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedTotal")]
        [Validation(Required=false)]
        public bool? NeedTotal { get; set; }

        /// <summary>
        /// <para>The page number. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start time for the query, specified as a Unix timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1742178604000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
