// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClientConfSetupResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of the Security Center agent.</para>
        /// </summary>
        [NameInMap("ClientConf")]
        [Validation(Required=false)]
        public DescribeClientConfSetupResponseBodyClientConf ClientConf { get; set; }
        public class DescribeClientConfSetupResponseBodyClientConf : TeaModel {
            /// <summary>
            /// <para>The configurations of the usage for the Security Center agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;mem&quot;:&quot;200&quot;,&quot;cpu&quot;:&quot;10&quot;,&quot;cpu_all&quot;:&quot;0&quot;}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The tag that is added to the configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>machineResource</para>
            /// </summary>
            [NameInMap("StrategyTag")]
            [Validation(Required=false)]
            public string StrategyTag { get; set; }

            /// <summary>
            /// <para>The value of the tag. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>major</description></item>
            /// <item><description>advanced</description></item>
            /// <item><description>basic</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>major</para>
            /// </summary>
            [NameInMap("StrategyTagValue")]
            [Validation(Required=false)]
            public string StrategyTagValue { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>151F6EB6-D5F3-417A-AF7B-4D84975D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
