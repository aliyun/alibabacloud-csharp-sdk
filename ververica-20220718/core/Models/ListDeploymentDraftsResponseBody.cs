// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ListDeploymentDraftsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of job drafts that match the query. This parameter is returned if the request is successful. If the request fails, this parameter is empty.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<DeploymentDraft> Data { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If the request fails, the error code is returned.</para>
        /// </description></item>
        /// <item><description><para>If the request is successful, this parameter is empty.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><para>If the request fails, the error message is returned.</para>
        /// </description></item>
        /// <item><description><para>If the request is successful, this parameter is empty.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code. If this parameter is not empty and its value is not 200, the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries on the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBC799F0-AS7S-1D30-8A4F-882ED4DD****</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries that match the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69</para>
        /// </summary>
        [NameInMap("totalSize")]
        [Validation(Required=false)]
        public int? TotalSize { get; set; }

    }

}
