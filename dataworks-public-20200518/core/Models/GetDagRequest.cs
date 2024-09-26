// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDagRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the DAG. You can use one of the following method to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/2780209.html">RunCycleDagNodes</a> operation and obtain the value of the <b>Data</b> response parameter.</description></item>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/2780210.html">RunSmokeTest</a> operation and obtain the value of the <b>Data</b> response parameter.</description></item>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/2780218.html">RunManualDagNodes</a> operation and obtain the value of the <b>DagId</b> response parameter.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123141452344525</para>
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// <para>The environment of the workspace. Valid values: PROD and DEV.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

    }

}
