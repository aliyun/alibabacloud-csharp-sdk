// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListAsynJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The tasks.</para>
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<ListAsynJobsResponseBodyJobs> Jobs { get; set; }
        public class ListAsynJobsResponseBodyJobs : TeaModel {
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
            /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2134663231234</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>If the value of <b>Status</b> is Failed, an error code is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>506</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>If the value of <b>Status</b> is Failed, an error message is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AllocateEipAddress Failed</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>365F4154-92F6-4AE4-92F8-7FF34B5****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates the end time of the task. Unit: milliseconds.</para>
            /// <para>This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2144663233315</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The type of the operation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Create</b></description></item>
            /// <item><description><b>Update</b></description></item>
            /// <item><description><b>Delete</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Create</para>
            /// </summary>
            [NameInMap("OperateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

            /// <summary>
            /// <para>The associated resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-o8mszt95oamfjy****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The type of the associated resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>loadbalancer</b>: an ALB instance</description></item>
            /// <item><description><b>listener</b>: a listener</description></item>
            /// <item><description><b>rule</b>: a forwarding rule</description></item>
            /// <item><description><b>acl</b>: an ACL</description></item>
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

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Succeeded</b></description></item>
            /// <item><description><b>Failed</b></description></item>
            /// <item><description><b>Processing</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is the token that determines the start point of the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
