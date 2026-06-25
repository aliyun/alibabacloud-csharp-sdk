// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ConfirmPipelineBatchRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to start the next batch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Start the next batch.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Terminate the process.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Confirm")]
        [Validation(Required=false)]
        public bool? Confirm { get; set; }

        /// <summary>
        /// <para>The pipeline ID. To obtain the ID, call the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/sae/serverless-app-engine-upgrade/developer-reference/api-sae-2019-05-06-describechangeorder?spm=a2c4g.11186623.help-menu-search-118957.d_0">DescribeChangeOrder</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/sae/serverless-app-engine-classic/developer-reference/api-sae-2019-05-06-describechangeorder-old?spm=a2c63.p38356.help-menu-search-118957.d_0">DescribeChangeOrder</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e2e-vds-feh-***</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

    }

}
