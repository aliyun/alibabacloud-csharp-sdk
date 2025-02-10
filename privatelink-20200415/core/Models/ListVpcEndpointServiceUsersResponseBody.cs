// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class ListVpcEndpointServiceUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If no value is returned for <b>NextToken</b>, no next requests are performed.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value can be used in the next request to retrieve a new page of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED8D006-F706-4D23-88ED-E11ED28DCAC0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

        /// <summary>
        /// <para>The whitelists in the format of Aliyun Resource Name (ARN).</para>
        /// </summary>
        [NameInMap("UserARNs")]
        [Validation(Required=false)]
        public List<ListVpcEndpointServiceUsersResponseBodyUserARNs> UserARNs { get; set; }
        public class ListVpcEndpointServiceUsersResponseBodyUserARNs : TeaModel {
            /// <summary>
            /// <para>The whitelist in the format of ARN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram:<em>::</em></para>
            /// </summary>
            [NameInMap("UserARN")]
            [Validation(Required=false)]
            public string UserARN { get; set; }

        }

        /// <summary>
        /// <para>The Alibaba Cloud accounts in the whitelist of the endpoint service.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<ListVpcEndpointServiceUsersResponseBodyUsers> Users { get; set; }
        public class ListVpcEndpointServiceUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account in the whitelist of the endpoint service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345678</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

    }

}
