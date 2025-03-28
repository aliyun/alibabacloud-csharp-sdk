// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateConsumerChannelRequest : TeaModel {
        /// <summary>
        /// <para>The name of the consumer group. The name can be up to 128 characters in length. We recommend that you use an informative name for easy identification.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>订阅组A</para>
        /// </summary>
        [NameInMap("ConsumerGroupName")]
        [Validation(Required=false)]
        public string ConsumerGroupName { get; set; }

        /// <summary>
        /// <para>The password of the consumer group.</para>
        /// <list type="bullet">
        /// <item><description>A password must contain two or more of the following characters: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>A password must be 8 to 32 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test123456</para>
        /// </summary>
        [NameInMap("ConsumerGroupPassword")]
        [Validation(Required=false)]
        public string ConsumerGroupPassword { get; set; }

        /// <summary>
        /// <para>The username of the consumer group.</para>
        /// <list type="bullet">
        /// <item><description>A username must contain one or more of the following characters: uppercase letters, lowercase letters, digits, and underscores (_).</description></item>
        /// <item><description>A username cannot exceed 16 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("ConsumerGroupUserName")]
        [Validation(Required=false)]
        public string ConsumerGroupUserName { get; set; }

        /// <summary>
        /// <para>The ID of the change tracking instance. You can call the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> operation to query the instance ID.</para>
        /// <remarks>
        /// <para> You must specify at least one of the <b>DtsInstanceId</b> and <b>DtsJobId</b>. parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtsboss6pn1w******</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the change tracking task. You can call the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> operation to query the task ID.</para>
        /// <remarks>
        /// <para> You must specify at least one of the <b>DtsInstanceId</b> and <b>DtsJobId</b>. parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>boss6pn1w******</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the change tracking instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2zx4uizich7y</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
