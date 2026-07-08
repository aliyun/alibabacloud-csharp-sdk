// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListWorkerResourceRequest : TeaModel {
        /// <summary>
        /// <para>The cloud service in the deployment task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NLB</para>
        /// </summary>
        [NameInMap("CloudProduct")]
        [Validation(Required=false)]
        public string CloudProduct { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The ID of the deployment task. You can call the <a href="https://help.aliyun.com/document_detail/2712234.html">CreateDeploymentJob</a> operation to obtain the ID of a deployment task from the <b>ID</b> parameter. You can also call the <a href="https://help.aliyun.com/document_detail/2712223.html">ListDeploymentJob</a> operation to obtain the ID of a deployment task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8888</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public int? ShowSize { get; set; }

        /// <summary>
        /// <para>The status of the worker task.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>rollback</para>
        /// </description></item>
        /// <item><description><para>rollback_error</para>
        /// </description></item>
        /// <item><description><para>success</para>
        /// </description></item>
        /// <item><description><para>rollback_success</para>
        /// </description></item>
        /// <item><description><para>pending</para>
        /// </description></item>
        /// <item><description><para>scheduling</para>
        /// </description></item>
        /// <item><description><para>processing</para>
        /// </description></item>
        /// <item><description><para>error</para>
        /// </description></item>
        /// <item><description><para>editing</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>editing</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
