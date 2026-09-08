// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class RedialCallRequest : TeaModel {
        /// <summary>
        /// <para>Callee number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1318888****</para>
        /// </summary>
        [NameInMap("Callee")]
        [Validation(Required=false)]
        public string Callee { get; set; }

        /// <summary>
        /// <para>Caller number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0109810****</para>
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// <para>Unique ID provided by the agent endpoint to identify an agent Workbench.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CCC-x.x.x.x-chrome102-bsdf911812c60f61e</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>Instance ID of the call center.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Call job ID. The job ID of the previous call used for redialing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-6581536084722****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>Per-call data. It must not exceed 128 bytes and is primarily used for extension purposes. Ordinary customers do not need to pay attention to it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a=b</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>Timeout. If the call is not answered within the time specified by this parameter, it is automatically disconnected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// <para>User ID of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>samzhang@abc</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
