// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ServerResponseManageAlertRulesResult : TeaModel {
        /// <summary>
        /// <para>The status code of the API response. A value of 200 indicates a successful request. Other values indicate a request exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data returned by the API, which contains the execution result details of alert rule management operations such as batch enabling or disabling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;updatedUuidList&quot;:[&quot;a1b2c3d4-e5f6-7890-abcd-ef1234567890&quot;]}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ManageAlertRulesResult Data { get; set; }

        /// <summary>
        /// <para>The error description returned when the request fails. This parameter is empty when the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified alert rule UUID does not exist.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The cursor for the next page in keyset-based pagination. A value of null indicates that no more data is available. Use this value to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records per page in the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique ID of the API request, which is used for troubleshooting and correlating server-side logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-7890-ABCD-EF1234567890</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of alert rules actually affected by the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
