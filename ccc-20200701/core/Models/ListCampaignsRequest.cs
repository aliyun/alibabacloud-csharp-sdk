// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCampaignsRequest : TeaModel {
        /// <summary>
        /// <para>The actual start time of the campaign. This parameter is optional. By default, all time ranges are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1780329600000</para>
        /// </summary>
        [NameInMap("ActualStartTimeFrom")]
        [Validation(Required=false)]
        public string ActualStartTimeFrom { get; set; }

        /// <summary>
        /// <para>The actual end time of the campaign. This parameter is optional. By default, all time ranges are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1781625600000</para>
        /// </summary>
        [NameInMap("ActualStartTimeTo")]
        [Validation(Required=false)]
        public string ActualStartTimeTo { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Filters campaigns by predictive dialing campaign name. Fuzzy match is not supported. This parameter is optional and defaults to empty, which indicates no filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-campaign</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size. Valid values: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The planned start time of the campaign. This parameter is optional. By default, all time ranges are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1780243200000</para>
        /// </summary>
        [NameInMap("PlanedStartTimeFrom")]
        [Validation(Required=false)]
        public string PlanedStartTimeFrom { get; set; }

        /// <summary>
        /// <para>The planned end time of the campaign. This parameter is optional. By default, all time ranges are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1781798399000</para>
        /// </summary>
        [NameInMap("PlanedStartTimeTo")]
        [Validation(Required=false)]
        public string PlanedStartTimeTo { get; set; }

        /// <summary>
        /// <para>Filters campaigns by skill group ID. This parameter is optional and defaults to empty, which indicates no filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skillgroup@ccc-test</para>
        /// </summary>
        [NameInMap("QueueId")]
        [Validation(Required=false)]
        public string QueueId { get; set; }

        /// <summary>
        /// <para>Filters campaigns by predictive dialing campaign state. This parameter is optional and defaults to empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Draft</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
