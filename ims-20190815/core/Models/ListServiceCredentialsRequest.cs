// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListServiceCredentialsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query service credentials for all Resource Access Management (RAM) users under the Alibaba Cloud account.</para>
        /// <para>If this parameter is set to true, you cannot specify UserPrincipalName at the same time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("AllUsers")]
        [Validation(Required=false)]
        public bool? AllUsers { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. You do not need to specify this parameter for the first API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE*******</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The service name of the Alibaba Cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The logon name of the Resource Access Management (RAM) user.</para>
        /// <para>Queries the service credentials of the specified RAM user.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
        /// </summary>
        [NameInMap("UserPrincipalName")]
        [Validation(Required=false)]
        public string UserPrincipalName { get; set; }

    }

}
