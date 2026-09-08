// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class StartBack2BackCallRequest : TeaModel {
        /// <summary>
        /// <para>Additional intermediate number. If this parameter is provided, the intermediate number specified by the Broker parameter is used to call the caller, and the number specified by this parameter is used to call the callee. This parameter is optional and defaults to empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0102156****</para>
        /// </summary>
        [NameInMap("AdditionalBroker")]
        [Validation(Required=false)]
        public string AdditionalBroker { get; set; }

        /// <summary>
        /// <para>The intermediate number, which must be an active outbound number under the instance. This number is used to sequentially call the caller and the callee in a double-call scenario.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0102157****</para>
        /// </summary>
        [NameInMap("Broker")]
        [Validation(Required=false)]
        public string Broker { get; set; }

        /// <summary>
        /// <para>The callee number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1372168****</para>
        /// </summary>
        [NameInMap("Callee")]
        [Validation(Required=false)]
        public string Callee { get; set; }

        /// <summary>
        /// <para>Caller number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1391814****</para>
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Ingest endpoint data. It must not exceed 128 bytes and is primarily used for extension purposes. Ordinary customers do not need to concern themselves with it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The timeout for the dual-call, in seconds. If the call is not answered within the specified time, it will be automatically disconnected. This parameter is optional and defaults to 30 seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

    }

}
