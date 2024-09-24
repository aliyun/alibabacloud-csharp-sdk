// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClientConfSetupRequest : TeaModel {
        /// <summary>
        /// <para>The tag that is added to the server.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>major</para>
        /// </summary>
        [NameInMap("StrategyTagValue")]
        [Validation(Required=false)]
        public string StrategyTagValue { get; set; }

    }

}
