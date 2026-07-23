// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class UpdateEventStreamingBusinessOptionRequest : TeaModel {
        /// <summary>
        /// <para>The billing mode. Valid values are CapacityUnitMode for the CU mode and EventNumMode for the pay-by-event mode.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CapacityUnitMode</para>
        /// </summary>
        [NameInMap("BusinessMode")]
        [Validation(Required=false)]
        public string BusinessMode { get; set; }

        /// <summary>
        /// <para>The name of the event stream.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rocketmq-sync</para>
        /// </summary>
        [NameInMap("EventStreamingName")]
        [Validation(Required=false)]
        public string EventStreamingName { get; set; }

        /// <summary>
        /// <para>The maximum number of CUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxCapacityUnitCount")]
        [Validation(Required=false)]
        public long? MaxCapacityUnitCount { get; set; }

        /// <summary>
        /// <para>The minimum number of CUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinCapacityUnitCount")]
        [Validation(Required=false)]
        public long? MinCapacityUnitCount { get; set; }

    }

}
