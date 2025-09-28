// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class EventRebootInstanceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e-9d992570200d86b9126d78aa8c37b54b</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immediate</para>
        /// </summary>
        [NameInMap("OpsType")]
        [Validation(Required=false)]
        public string OpsType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1742452232000</para>
        /// </summary>
        [NameInMap("PlanTime")]
        [Validation(Required=false)]
        public long? PlanTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

    }

}
