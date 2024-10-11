// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCampaignsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-10-14 20:59:59</para>
        /// </summary>
        [NameInMap("ActualStartTimeFrom")]
        [Validation(Required=false)]
        public string ActualStartTimeFrom { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-10-14 20:59:59</para>
        /// </summary>
        [NameInMap("ActualStartTimeTo")]
        [Validation(Required=false)]
        public string ActualStartTimeTo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-campaign</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-10-14 00:00:00</para>
        /// </summary>
        [NameInMap("PlanedStartTimeFrom")]
        [Validation(Required=false)]
        public string PlanedStartTimeFrom { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-10-14 20:59:59</para>
        /// </summary>
        [NameInMap("PlanedStartTimeTo")]
        [Validation(Required=false)]
        public string PlanedStartTimeTo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>skillgroup@ccc-test</para>
        /// </summary>
        [NameInMap("QueueId")]
        [Validation(Required=false)]
        public string QueueId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Draft</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
