// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class BatchGetFileMetaShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the dataset. For more information about how to obtain the dataset name, refer to <a href="https://help.aliyun.com/document_detail/478160.html">Create a dataset</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information about how to obtain the project name, refer to <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The list of file URIs. A maximum of 100 URIs are supported.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("URIs")]
        [Validation(Required=false)]
        public string URIsShrink { get; set; }

        /// <summary>
        /// <para>The list of fields to be returned. If you specify this parameter, only the values of the specified fields are returned, instead of all existing metadata fields. This parameter can be used to reduce the size of the returned struct.</para>
        /// <para>If you do not specify this parameter or leave it empty, all fields are returned.</para>
        /// </summary>
        [NameInMap("WithFields")]
        [Validation(Required=false)]
        public string WithFieldsShrink { get; set; }

    }

}
