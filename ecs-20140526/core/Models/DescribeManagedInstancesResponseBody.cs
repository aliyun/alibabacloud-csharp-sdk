// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeManagedInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried managed instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeManagedInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeManagedInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The ID of the activation code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3704F543-F768-43FA-9864-897F75B3****</para>
            /// </summary>
            [NameInMap("ActivationId")]
            [Validation(Required=false)]
            public string ActivationId { get; set; }

            /// <summary>
            /// <para>The version number of Cloud Assistant Agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.0.102</para>
            /// </summary>
            [NameInMap("AgentVersion")]
            [Validation(Required=false)]
            public string AgentVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether the managed instance is connected. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The managed instance is connected. You can manage the instance by using Cloud Assistant.</description></item>
            /// <item><description>false: The managed instance is not connected. The managed instance may be down or Cloud Assistant Agent may be incorrectly installed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Connected")]
            [Validation(Required=false)]
            public bool? Connected { get; set; }

            /// <summary>
            /// <para>The hostname of the managed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            /// <summary>
            /// <para>The ID of the managed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mi-hz018jrc1o0****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the managed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>webAPP-linux-01</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The public IP address of the managed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40.65.**.**</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// <para>The internal IP address of the managed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.**.**</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The number of times that Cloud Assistant tasks were executed on the managed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InvocationCount")]
            [Validation(Required=false)]
            public long? InvocationCount { get; set; }

            /// <summary>
            /// <para>The time when the last Cloud Assistant task was executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-20T09:00:40Z</para>
            /// </summary>
            [NameInMap("LastInvokedTime")]
            [Validation(Required=false)]
            public string LastInvokedTime { get; set; }

            /// <summary>
            /// <para>The machine code of the managed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e03231b37ab14e53b5795ad625fc****</para>
            /// </summary>
            [NameInMap("MachineId")]
            [Validation(Required=false)]
            public string MachineId { get; set; }

            /// <summary>
            /// <para>The operating system type of the managed instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Linux</para>
            /// </summary>
            [NameInMap("OsType")]
            [Validation(Required=false)]
            public string OsType { get; set; }

            /// <summary>
            /// <para>The version information of the operating system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Linux_#38~18.04.1-Ubuntu SMP Wed Jan 6 18:26:30 UTC 2021_x86_64</para>
            /// </summary>
            [NameInMap("OsVersion")]
            [Validation(Required=false)]
            public string OsVersion { get; set; }

            /// <summary>
            /// <para>The time when the managed instance was registered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-20T08:57:56Z</para>
            /// </summary>
            [NameInMap("RegistrationTime")]
            [Validation(Required=false)]
            public string RegistrationTime { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the managed instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-123******</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The tags of the managed instance.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeManagedInstancesResponseBodyInstancesTags> Tags { get; set; }
            public class DescribeManagedInstancesResponseBodyInstancesTags : TeaModel {
                /// <summary>
                /// <para>The key of tag N of the managed instance. Valid values of N: 1 to 20. The tag key cannot be an empty string.</para>
                /// <para>If a single tag is specified to query resources, up to 1,000 resources that have this tag added are returned. If multiple tags are specified to query resources, up to 1,000 resources that have all these tags added are returned. To query more than 1,000 resources that have the specified tags, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation.</para>
                /// <para>The tag key can be up to 64 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of tag N of the managed instance. Valid values of N: 1 to 20. The tag value can be an empty string.</para>
                /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>77115469-F2C5-4ECA-94F7-FA04F2FD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of queried managed instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
