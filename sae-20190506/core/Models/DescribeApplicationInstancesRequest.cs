// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d700e680-aa4d-4ec1-afc2-6566b5ff****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The ID of the application group. Call the <a href="https://help.aliyun.com/document_detail/126249.html">DescribeApplicationGroups</a> operation to get the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b2a8a925-477a-4ed7-b825-d5e22500****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The application instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-faaca66c-5959-45cc-b3bf-d26093b2e9c0******</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>. The value must be in the range (0, 1000000000).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The batch ID. Call the <a href="https://help.aliyun.com/document_detail/126617.html">DescribeChangeOrder</a> operation to get the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85750d48-6cfc-4dbf-8ea0-840397******</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>Specifies the sort order of the application instances. Instances are sorted first by running status, and then by instance ID. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The instances are sorted in descending order.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The instances are sorted in ascending order.</para>
        /// </description></item>
        /// </list>
        /// <para>Instance statuses in ascending order:</para>
        /// <ol>
        /// <item><description><para><b>Error</b>: An error occurred during instance startup.</para>
        /// </description></item>
        /// <item><description><para><b>CrashLoopBackOff</b>: The container fails to start and enters a crash-restart loop.</para>
        /// </description></item>
        /// <item><description><para><b>ErrImagePull</b>: An error occurred while pulling the container image for the instance.</para>
        /// </description></item>
        /// <item><description><para><b>ImagePullBackOff</b>: The system is repeatedly trying and failing to pull the container image.</para>
        /// </description></item>
        /// <item><description><para><b>Pending</b>: The instance is waiting to be scheduled.</para>
        /// </description></item>
        /// <item><description><para><b>Unknown</b>: An unknown exception occurred.</para>
        /// </description></item>
        /// <item><description><para><b>Terminating</b>: The instance is being terminated.</para>
        /// </description></item>
        /// <item><description><para><b>NotFound</b>: The instance cannot be found.</para>
        /// </description></item>
        /// <item><description><para><b>PodInitializing</b>: The instance is being initialized.</para>
        /// </description></item>
        /// <item><description><para><b>Init:0/1</b>: The instance is being initialized.</para>
        /// </description></item>
        /// <item><description><para><b>Running</b>: The instance is running.</para>
        /// </description></item>
        /// </ol>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Reverse")]
        [Validation(Required=false)]
        public bool? Reverse { get; set; }

    }

}
