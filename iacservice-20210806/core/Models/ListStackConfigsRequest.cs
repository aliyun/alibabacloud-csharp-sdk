// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListStackConfigsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of records to read in this request. Default value: 20. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that marks the position from which to start reading. Leave empty to start from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s8UVlnE23gZvjCvCwkoZ7Z4dD+2BRJj42DLT6GrZysw=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The status of the stack configuration.</para>
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

        /// <summary>
        /// <para>The version number of the stack configuration, such as v1. The initial value is v1. The version number increments each time the stack is updated or refreshed and the configuration changes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v4</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
