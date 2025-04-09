// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SuspendJobsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6b3ea2a1-32b3-4041-842b-9bde5de9dda0</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>11994321-e6bc-47bb-8b1c-8eef8f2f768b</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public List<string> JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>de3ab269-6746-477c-b13d-bd49f13202c2</para>
        /// </summary>
        [NameInMap("JobReferenceId")]
        [Validation(Required=false)]
        public List<string> JobReferenceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4b6dd926-3cc3-4111-a333-15d9b006fe81</para>
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

    }

}
