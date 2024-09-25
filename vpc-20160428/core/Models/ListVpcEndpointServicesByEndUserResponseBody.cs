// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVpcEndpointServicesByEndUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If no value is returned for <b>NextToken</b>, no next queries are sent.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value is the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AB1129F-32C1-5E4D-9E22-E4A859CA46EB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of entries returned.</para>
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
            /// <para>The domain name of the cloud service to which the endpoint service belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss-admin.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ServiceDomain")]
            [Validation(Required=false)]
            public string ServiceDomain { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint service.</para>
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
            /// <para>Indicate whether the endpoint service supports the access policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b></description></item>
            /// <item><description><b>true</b></description></item>
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
