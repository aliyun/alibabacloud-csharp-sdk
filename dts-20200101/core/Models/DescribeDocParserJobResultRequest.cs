// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDocParserJobResultRequest : TeaModel {
        /// <summary>
        /// <para>The task ID (DtsJobId) returned when the document parsing task was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dts-20250729-y0zz3t13h7d****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The instance ID of the DTS RagFlow instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsgbe12he619iy801</para>
        /// </summary>
        [NameInMap("RagInstanceId")]
        [Validation(Required=false)]
        public string RagInstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the task. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
