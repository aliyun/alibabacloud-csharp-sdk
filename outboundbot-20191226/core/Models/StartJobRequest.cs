// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class StartJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>10086</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public List<string> CallingNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>da37319b-6c83-4268-9f19-814aed62e401</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4f21446e-324e-46f2-bf62-7f341fb004ea</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("JobJson")]
        [Validation(Required=false)]
        public string JobJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>af81a389-91f0-4157-8d82-720edd02b66a</para>
        /// </summary>
        [NameInMap("ScenarioId")]
        [Validation(Required=false)]
        public string ScenarioId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b9ff4e88-65f9-4eb3-987c-11ba51f3f24d</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

    }

}
