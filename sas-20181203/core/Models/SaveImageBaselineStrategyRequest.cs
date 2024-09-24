// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SaveImageBaselineStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The baseline check items.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeImageBaselineStrategy~~">DescribeImageBaselineStrategy</a> operation to query baseline check items.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ak_leak</para>
        /// </summary>
        [NameInMap("BaselineItemList")]
        [Validation(Required=false)]
        public string BaselineItemList { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The data source. If this parameter is left empty, the baseline check policy for images is queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: the baseline check policy for images</description></item>
        /// <item><description><b>agentless</b>: agentless detection</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agentless</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The ID of the baseline check policy.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeImageBaselineStrategy~~">DescribeImageBaselineStrategy</a> operation to query the IDs of baseline check policies.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8639</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

        /// <summary>
        /// <para>The name of the baseline check policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

    }

}
