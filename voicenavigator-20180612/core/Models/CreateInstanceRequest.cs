// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The maximum concurrency of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Concurrency")]
        [Validation(Required=false)]
        public long? Concurrency { get; set; }

        /// <summary>
        /// <para>The description of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一个测试场景</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the Voice Navigator instance, which identifies the digital employee scenario.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试场景</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Configuration parameters for the large language model service, in JSON format.</para>
        /// <list type="bullet">
        /// <item><description>Use this parameter to specify a Function Compute service.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("NluServiceParamsJson")]
        [Validation(Required=false)]
        public string NluServiceParamsJson { get; set; }

        /// <summary>
        /// <para>The ID of the source instance.</para>
        /// <remarks>
        /// <para>If you set UnionSource to CCC, set this parameter to the ID of the Cloud Contact Center instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>demo-lctms</para>
        /// </summary>
        [NameInMap("UnionInstanceId")]
        [Validation(Required=false)]
        public string UnionInstanceId { get; set; }

        /// <summary>
        /// <para>The source service.</para>
        /// <list type="bullet">
        /// <item><description>CCC: Cloud Contact Center</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CCC</para>
        /// </summary>
        [NameInMap("UnionSource")]
        [Validation(Required=false)]
        public string UnionSource { get; set; }

    }

}
