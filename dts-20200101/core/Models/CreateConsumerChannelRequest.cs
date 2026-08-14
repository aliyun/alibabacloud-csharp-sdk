// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateConsumerChannelRequest : TeaModel {
        /// <summary>
        /// <para>The name of the consumer group. The name can be up to 128 characters in length. Specify a business-meaningful name for easy identification.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>订阅组A</para>
        /// </summary>
        [NameInMap("ConsumerGroupName")]
        [Validation(Required=false)]
        public string ConsumerGroupName { get; set; }

        /// <summary>
        /// <para>The password of the consumer group account.</para>
        /// <list type="bullet">
        /// <item><description>The password must contain characters from at least two of the following categories: uppercase letters, lowercase letters, digits, and special characters.</description></item>
        /// <item><description>The password must be 8 to 32 characters in length.</description></item>
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
        /// <para>The username of the consumer group account.</para>
        /// <para>The username can contain uppercase letters, lowercase letters, digits, and underscores (_). The username can be up to 16 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("ConsumerGroupUserName")]
        [Validation(Required=false)]
        public string ConsumerGroupUserName { get; set; }

        /// <summary>
        /// <para>The ID of the change tracking instance. You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to query the instance ID.</para>
        /// <remarks>
        /// <para>You must specify one of the <b>DtsInstanceId</b> and <b>DtsJobId</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtsboss6pn1w******</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the change tracking task. You can call <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> to query the task ID.</para>
        /// <remarks>
        /// <para>You must specify one of the <b>DtsInstanceId</b> and <b>DtsJobId</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>boss6pn1w******</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the DTS change tracking instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>rg-aek2zx4uizich7y</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
