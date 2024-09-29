// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetAgentDownloadUrlV2Request : TeaModel {
        /// <summary>
        /// <para>The agent type.\
        /// <b>Valid values:</b></para>
        /// <list type="bullet">
        /// <item><description><b>JavaAgent</b></description></item>
        /// <item><description><b>Instgo</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JavaAgent</para>
        /// </summary>
        [NameInMap("AgentType")]
        [Validation(Required=false)]
        public string AgentType { get; set; }

        /// <summary>
        /// <para>The architecture type of the environment where the agent is installed.\
        /// This parameter is required and valid only when <b>AgentType</b> is set to <b>Instgo</b>.\
        /// <b>Valid values:</b></para>
        /// <list type="bullet">
        /// <item><description><b>amd64</b></description></item>
        /// <item><description><b>arm64</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>amd64</para>
        /// </summary>
        [NameInMap("ArchType")]
        [Validation(Required=false)]
        public string ArchType { get; set; }

        /// <summary>
        /// <para>The operating system of the environment where the agent is installed.\
        /// This parameter is required and valid only when <b>AgentType</b> is set to <b>Instgo</b>.\
        /// <b>Valid values:</b></para>
        /// <list type="bullet">
        /// <item><description><b>linux</b></description></item>
        /// <item><description><b>darwin</b></description></item>
        /// <item><description><b>windows</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

    }

}
