// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVpcEndpointServicesByEndUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query exists.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token for the next query.</description></item>
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
        /// <para>0AB1129F-32C1-5E4D-9E22-E4A859CA46EB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of available endpoint services.</para>
        /// </summary>
        [NameInMap("Services")]
        [Validation(Required=false)]
        public List<ListVpcEndpointServicesByEndUserResponseBodyServices> Services { get; set; }
        public class ListVpcEndpointServicesByEndUserResponseBodyServices : TeaModel {
            /// <summary>
            /// <para>The default access policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{   \&quot;Version\&quot; : \&quot;1\&quot;,   \&quot;Statement\&quot; : [ {     \&quot;Effect\&quot; : \&quot;Allow\&quot;,     \&quot;Action\&quot; : \&quot;<em>\&quot;,     \&quot;Principal\&quot; : \&quot;</em>\&quot;,     \&quot;Resource\&quot; : \&quot;*\&quot;   } ] }</para>
            /// </summary>
            [NameInMap("DefaultPolicyDocument")]
            [Validation(Required=false)]
            public string DefaultPolicyDocument { get; set; }

            /// <summary>
            /// <para>The domain name of the cloud service associated with the endpoint service in the queried region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-admin.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ServiceDomain")]
            [Validation(Required=false)]
            public string ServiceDomain { get; set; }

            /// <summary>
            /// <para>The instance ID of the endpoint service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpces-m5enwdmilo210aibo9****</para>
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// <para>The name of the endpoint service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>com.aliyun.cn-hangzhou.oss</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>Indicates whether the endpoint service supports access policies. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b>: Access policies are not supported.</description></item>
            /// <item><description><b>true</b>: Access policies are supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportPolicy")]
            [Validation(Required=false)]
            public bool? SupportPolicy { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
