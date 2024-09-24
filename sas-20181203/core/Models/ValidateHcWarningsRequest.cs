// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ValidateHcWarningsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of check items that you want to verify. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para>You can use <a href="https://help.aliyun.com/document_detail/116179.html">DescribeCheckWarningSummary</a> to get IDs of check items.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>695,234</para>
        /// </summary>
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public string CheckIds { get; set; }

        /// <summary>
        /// <para>The IDs of risk items that you want to verify. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("RiskIds")]
        [Validation(Required=false)]
        public string RiskIds { get; set; }

        /// <summary>
        /// <para>The status of the check item that you want to verify.</para>
        /// <list type="bullet">
        /// <item><description>1: failed</description></item>
        /// <item><description>3: passed</description></item>
        /// <item><description>5: expired</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers on which you want to verify the risk items. Separate multiple UUIDs with commas (,).</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the UUIDs of servers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>78645c8e-2e89-441b-8eb,a9622a6b-adb5-4dd3-929e,0136460a-1cb5-44e8-****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
