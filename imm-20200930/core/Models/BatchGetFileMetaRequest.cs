// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class BatchGetFileMetaRequest : TeaModel {
        /// <summary>
        /// <para>The name of the dataset.<a href="~~478160~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The name of the project.<a href="~~478153~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The array of object URIs. You can specify up to 100 object URIs in an array.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("URIs")]
        [Validation(Required=false)]
        public List<string> URIs { get; set; }

        /// <summary>
        /// <para>The fields to return. If you specify this parameter, only specified metadata fields are returned. You can use this parameter to control the size of the response.</para>
        /// <para>If you do not specify this parameter or leave this parameter empty, the operation returns all metadata fields.</para>
        /// </summary>
        [NameInMap("WithFields")]
        [Validation(Required=false)]
        public List<string> WithFields { get; set; }

    }

}
