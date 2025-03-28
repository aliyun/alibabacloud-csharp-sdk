// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyDtsJobConfigRequest : TeaModel {
        /// <summary>
        /// <para>DTS job ID, which can be queried by calling <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lxsn87r328d****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The parameters that you want to modify. Specify a JSON string. For more information, see <a href="https://help.aliyun.com/document_detail/2536412.html">Parameters</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;module\&quot;:\&quot;07\&quot;,\&quot;name\&quot;:\&quot;sink.connection.idle.second\&quot;,\&quot;value\&quot;:60},{\&quot;module\&quot;:\&quot;07\&quot;,\&quot;name\&quot;:\&quot;sink.batch.size.maximum\&quot;,\&quot;value\&quot;:64}]</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The region where the instance is located. For more details, see <a href="https://help.aliyun.com/document_detail/141033.html">List of Supported Regions</a>.</para>
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
