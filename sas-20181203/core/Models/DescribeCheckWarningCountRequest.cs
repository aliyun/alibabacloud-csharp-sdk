// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckWarningCountRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>103784262032****</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <para>The ID of the check item.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListCheckItemWarningSummary~~">ListCheckItemWarningSummary</a> operation to query the IDs of check items.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>926</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>The ID of the risk item.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeCheckWarningSummary~~">DescribeCheckWarningSummary</a> operation to query the IDs of risk items.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("RiskId")]
        [Validation(Required=false)]
        public long? RiskId { get; set; }

        /// <summary>
        /// <para>The status of the check item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: failed</description></item>
        /// <item><description><b>2</b>: verifying</description></item>
        /// <item><description><b>3</b>: passed</description></item>
        /// <item><description><b>6</b>: ignored</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
