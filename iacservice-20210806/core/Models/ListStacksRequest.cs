// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListStacksRequest : TeaModel {
        /// <summary>
        /// <para>The keyword used to perform a fuzzy search by stack name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key</para>
        /// </summary>
        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The key ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21a90f5d-a469-4ac4-a8ea-f6e1e7470e6f</para>
        /// </summary>
        [NameInMap("kmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>The maximum number of results to return. Default value: 100. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. This parameter is empty if no more pages are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LC4NJL3Ru2bIiRdnbADPQp4dD+2BRJj42DLT6GrZysw=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of results returned per page. Default value: 20. Minimum value: 1. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The stack status.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Creating</td>
        /// <td>Being created.</td>
        /// </tr>
        /// <tr>
        /// <td>Created</td>
        /// <td>Created.</td>
        /// </tr>
        /// <tr>
        /// <td>Waiting</td>
        /// <td>Waiting for deployment.</td>
        /// </tr>
        /// <tr>
        /// <td>Deploying</td>
        /// <td>Being deployed.</td>
        /// </tr>
        /// <tr>
        /// <td>Deployed</td>
        /// <td>Deployed.</td>
        /// </tr>
        /// <tr>
        /// <td>Errored</td>
        /// <td>Deployment failed.</td>
        /// </tr>
        /// <tr>
        /// <td>Deleting</td>
        /// <td>Being deleted.</td>
        /// </tr>
        /// <tr>
        /// <td>Deleted</td>
        /// <td>Deleted.</td>
        /// </tr>
        /// <tr>
        /// <td>DeleteFailed</td>
        /// <td>Deletion failed.</td>
        /// </tr>
        /// <tr>
        /// <td>DetectTriggered</td>
        /// <td>Drift detection triggered.</td>
        /// </tr>
        /// </tbody></table>
        /// 
        /// <b>Example:</b>
        /// <para>Deployed</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
