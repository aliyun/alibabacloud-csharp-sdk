// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SaveImageBaselineStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The baseline items.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeImageBaselineStrategy~~">DescribeImageBaselineStrategy</a> API to obtain the value of this parameter.</para>
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
        /// <para>The baseline risk retention period, in days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("ImageVulClean")]
        [Validation(Required=false)]
        public int? ImageVulClean { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The data source. If you do not specify this parameter, the operation queries image baseline strategies by default. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>default</b>: image</para>
        /// </description></item>
        /// <item><description><para><b>agentless</b>: agentless</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agentless</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The ID of the baseline check strategy.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeImageBaselineStrategy~~">DescribeImageBaselineStrategy</a> API to obtain the value of this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8639</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

        /// <summary>
        /// <para>The name of the baseline check strategy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

    }

}
