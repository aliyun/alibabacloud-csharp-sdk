// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListAsynJobsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateLoadBalancer</para>
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates the start time of the task. Unit: milliseconds.</para>
        /// <para>Specify the timestamp in the Unix format to indicate the total amount of time that is from 00:00:00 (UTC+0) on January 1, 1970 to when the status of the asynchronous task is queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-03T17:22Z</para>
        /// </summary>
        [NameInMap("BeginTime")]
        [Validation(Required=false)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates the end time of the task. Unit: milliseconds.</para>
        /// <para>Specify the timestamp in the Unix format to indicate the total amount of time that is from 00:00:00 (UTC+0) on January 1, 1970 to when the status of the asynchronous task is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-06-04T17:22Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The asynchronous task IDs.</para>
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public List<string> JobIds { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request.</description></item>
        /// <item><description>You must specify the token that is obtained from the previous query as the value of <b>NextToken</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The resource IDs.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// <para>The type of the associated resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>loadbalancer</b>: an Application Load Balancer (ALB) instance</description></item>
        /// <item><description><b>listener</b>: a listener</description></item>
        /// <item><description><b>rule</b>: a forwarding rule</description></item>
        /// <item><description><b>acl</b>: an access control list (ACL)</description></item>
        /// <item><description><b>securitypolicy</b>: a security policy</description></item>
        /// <item><description><b>servergroup</b>: a server group</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>acl</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
