// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateWhiteListStrategyStatusRequest : TeaModel {
        /// <summary>
        /// <para>The language type for the request and response messages. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The source IP address of the request. You do not need to specify this parameter. The system automatically obtains this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>219.143.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The policy status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Deleted.</description></item>
        /// <item><description><b>1</b>: Learning.</description></item>
        /// <item><description><b>2</b>: Paused.</description></item>
        /// <item><description><b>3</b>: Learning complete.</description></item>
        /// <item><description><b>4</b>: Active.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Only a policy in the <b>Learning</b> state can be changed to the <b>Paused</b> state.</description></item>
        /// <item><description>Only a policy in the <b>Paused</b> state can be changed to the <b>Learning</b> state.</description></item>
        /// <item><description>Only a policy in the <b>Learning complete</b> state can be changed to the <b>Active</b> state.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeWhiteListStrategyList~~">DescribeWhiteListStrategyList</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8516</para>
        /// </summary>
        [NameInMap("StrategyIds")]
        [Validation(Required=false)]
        public string StrategyIds { get; set; }

    }

}
