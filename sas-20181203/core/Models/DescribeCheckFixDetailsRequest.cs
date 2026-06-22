// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckFixDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the check item.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeRiskType~~">DescribeRiskType</a> operation to obtain the check item ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>58</para>
        /// </summary>
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public string CheckIds { get; set; }

        /// <summary>
        /// <para>The language type of the request and response. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The ID of the baseline.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/116179.html">DescribeCheckWarningSummary</a> operation to obtain the baseline ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>51</para>
        /// </summary>
        [NameInMap("RiskId")]
        [Validation(Required=false)]
        public long? RiskId { get; set; }

    }

}
