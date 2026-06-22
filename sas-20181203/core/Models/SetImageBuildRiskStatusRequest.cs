// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class SetImageBuildRiskStatusRequest : TeaModel {
        /// <summary>
        /// <para>The image UUIDs. Separate multiple UUIDs with commas (,).</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeImageInstances~~">DescribeImageInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>f382fccd88b94c5c8c864def681*****,ac32fccd88b94c5c8c864def681*****</para>
        /// </summary>
        [NameInMap("ImageUuids")]
        [Validation(Required=false)]
        public string ImageUuids { get; set; }

        /// <summary>
        /// <para>The risk keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>risk.type</para>
        /// </summary>
        [NameInMap("RiskKey")]
        [Validation(Required=false)]
        public string RiskKey { get; set; }

        /// <summary>
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Unhandled.</description></item>
        /// <item><description><b>1</b>: Ignored.</description></item>
        /// <item><description><b>2</b>: False positive.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
