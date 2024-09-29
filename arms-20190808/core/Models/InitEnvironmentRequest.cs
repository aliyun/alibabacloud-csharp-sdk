// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class InitEnvironmentRequest : TeaModel {
        /// <summary>
        /// <para>The language. Valid values: zh and en. Default value: zh.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <para>Specifies whether to create a token to improve data security.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CreateAuthToken")]
        [Validation(Required=false)]
        public bool? CreateAuthToken { get; set; }

        /// <summary>
        /// <para>The ID of the environment instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-xxx</para>
        /// </summary>
        [NameInMap("EnvironmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>Whether agents or exporters are managed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: No. By default, no managed agents or exporters are provided for ACK clusters.</description></item>
        /// <item><description>agent: Agents are managed. By default, managed agents are provided for ASK clusters, ACS clusters, and ACK One clusters.</description></item>
        /// <item><description>agent-exproter: Agents and exporters are managed. By default, managed agents and exporters are provided for cloud services.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agent</para>
        /// </summary>
        [NameInMap("ManagedType")]
        [Validation(Required=false)]
        public string ManagedType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
