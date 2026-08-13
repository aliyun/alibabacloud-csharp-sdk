// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListCampaignsRequest : TeaModel {
        /// <summary>
        /// <para>The earliest actual start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634054400000</para>
        /// </summary>
        [NameInMap("ActualStartTimeFrom")]
        [Validation(Required=false)]
        public string ActualStartTimeFrom { get; set; }

        /// <summary>
        /// <para>The latest actual start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634054400000</para>
        /// </summary>
        [NameInMap("ActualStartTimeTo")]
        [Validation(Required=false)]
        public string ActualStartTimeTo { get; set; }

        /// <summary>
        /// <para>The instance ID of the outbound robot.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a4274627-265f-4e14-b2d6-4ee7d4f8593e</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the campaign.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SatisfactionSurvey</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The earliest planned start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634054400000</para>
        /// </summary>
        [NameInMap("PlannedStartTimeFrom")]
        [Validation(Required=false)]
        public string PlannedStartTimeFrom { get; set; }

        /// <summary>
        /// <para>The latest planned start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634054400000</para>
        /// </summary>
        [NameInMap("PlannedStartTimeTo")]
        [Validation(Required=false)]
        public string PlannedStartTimeTo { get; set; }

        /// <summary>
        /// <para>The status of the campaign.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Completed</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
