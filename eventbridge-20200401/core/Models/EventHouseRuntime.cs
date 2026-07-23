// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class EventHouseRuntime : TeaModel {
        /// <summary>
        /// <para>The number of CUs that last took effect for the EventHouse Runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cu")]
        [Validation(Required=false)]
        public int? Cu { get; set; }

        /// <summary>
        /// <para>The stable error code returned when the creation or specification change operation fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNTIME_OPERATION_TIMEOUT</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The desensitized error message returned when the creation or specification change operation fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Runtime operation timed out</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The name of the EventHouse Runtime. Typically set to default in the initial phase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The progress of the current creation or specification change operation. Valid values: 0 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Progress")]
        [Validation(Required=false)]
        public int? Progress { get; set; }

        /// <summary>
        /// <para>The current stage of the creation or specification change operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNTIME_HEALTH_CHECK</para>
        /// </summary>
        [NameInMap("Stage")]
        [Validation(Required=false)]
        public string Stage { get; set; }

        /// <summary>
        /// <para>The current status of the EventHouse Runtime. RUNNING indicates that the Runtime is ready and can accept queries. Valid values: CREATING, RUNNING, UPDATING, RECOVERING, CLOSED, CREATE_FAILED, and UPDATE_FAILED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The target number of CUs during creation, specification change, or the corresponding failed state. This parameter is not returned when the Runtime is running stably.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TargetCu")]
        [Validation(Required=false)]
        public int? TargetCu { get; set; }

    }

}
