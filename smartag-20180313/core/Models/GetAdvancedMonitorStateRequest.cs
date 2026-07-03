// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class GetAdvancedMonitorStateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region where the Smart Access Gateway instance is deployed.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/69813.html">DescribeRegions</a> operation to obtain the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Smart Access Gateway instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-asdfz6ac74oj5v****</para>
        /// </summary>
        [NameInMap("SagId")]
        [Validation(Required=false)]
        public string SagId { get; set; }

    }

}
