// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ListDeploymentsRequest : TeaModel {
        /// <summary>
        /// <para>Creator UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>183899668*******</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>Deployment execution mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STREAMING</para>
        /// </summary>
        [NameInMap("executionMode")]
        [Validation(Required=false)]
        public string ExecutionMode { get; set; }

        /// <summary>
        /// <para>Label name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key</para>
        /// </summary>
        [NameInMap("labelKey")]
        [Validation(Required=false)]
        public string LabelKey { get; set; }

        /// <summary>
        /// <para>Tag values. Multiple values are separated by semicolons.</para>
        /// 
        /// <b>Example:</b>
        /// <para>value1,value2</para>
        /// </summary>
        [NameInMap("labelValueArray")]
        [Validation(Required=false)]
        public string LabelValueArray { get; set; }

        /// <summary>
        /// <para>Modifier UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>183899668*******</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// <para>Deployment name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vvp_ds_0522</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Pagination parameter. Page index indicating the requested page number. Minimum value is 1. Default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>Pagination parameter. Number of elements on the requested page. Maximum value is 100, minimum value is 1, and default value is 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Sorting method. Supports returning data in descending order by creation time or updated time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gmt_create</para>
        /// </summary>
        [NameInMap("sortName")]
        [Validation(Required=false)]
        public string SortName { get; set; }

        /// <summary>
        /// <para>The status of the latest job for the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
