// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class InitEnvironmentRequest : TeaModel {
        /// <summary>
        /// <para>The language. Valid values: zh and en. Default: zh.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AliyunLang")]
        [Validation(Required=false)]
        public string AliyunLang { get; set; }

        /// <summary>
        /// <para>Whether to create an authentication token for enhanced data security.</para>
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
        /// <para>The agent management mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>none: unmanaged. Default for ACK clusters.</para>
        /// </description></item>
        /// <item><description><para>agent: managed agents only. Default for ASK, ACS, and ACK One clusters.</para>
        /// </description></item>
        /// <item><description><para>agent-exproter: managed agents and exporters. Default for cloud services.</para>
        /// </description></item>
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
