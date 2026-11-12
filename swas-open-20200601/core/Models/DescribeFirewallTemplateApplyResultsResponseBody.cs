// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class DescribeFirewallTemplateApplyResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30637AD6-D977-4833-A54C-CC89483E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of firewall rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// <para>The returned results.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<DescribeFirewallTemplateApplyResultsResponseBodyData> Data { get; set; }
        public class DescribeFirewallTemplateApplyResultsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the firewall template application task was executed, in the format of EEE MMM dd HH:mm:ss zzz yyyy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tue May 14 11:53:07 CST 2024</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The total number of instances to which the firewall template failed to be applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public string FailedCount { get; set; }

            /// <summary>
            /// <para>The firewall template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ft-bcf1a7hrdq717****</para>
            /// </summary>
            [NameInMap("FirewallTemplateId")]
            [Validation(Required=false)]
            public string FirewallTemplateId { get; set; }

            /// <summary>
            /// <para>The results of applying the firewall template to instances.</para>
            /// </summary>
            [NameInMap("InstanceApplyResults")]
            [Validation(Required=false)]
            public List<DescribeFirewallTemplateApplyResultsResponseBodyDataInstanceApplyResults> InstanceApplyResults { get; set; }
            public class DescribeFirewallTemplateApplyResultsResponseBodyDataInstanceApplyResults : TeaModel {
                /// <summary>
                /// <para>The simple application server instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33774babccc84003a2b1ad47e8001233</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The status of applying the firewall template to a specific instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Running: The firewall template is being applied.</description></item>
                /// <item><description>Failed: The firewall template failed to be applied.</description></item>
                /// <item><description>Success: The firewall template was applied.</description></item>
                /// <item><description>PartFailed: The firewall template was partially applied. Some rules failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The status of applying the firewall template to all instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running: The firewall template is being applied.</description></item>
            /// <item><description>Failed: The firewall template failed to be applied to all instances.</description></item>
            /// <item><description>Success: The firewall template was applied.</description></item>
            /// <item><description>PartFailed: The firewall template was partially applied. Some instances failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the template application task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aft-ikgt0bynitvs3****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The total number of instances to which the firewall template is applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

    }

}
