// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class SemanticQueryRequest : TeaModel {
        /// <summary>
        /// <para>The name of the dataset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The maximum number of data records to return in this request. Value range: (0,100].</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The media types to search. If this parameter is left empty, the default value is:</para>
        /// </summary>
        [NameInMap("MediaTypes")]
        [Validation(Required=false)]
        public List<string> MediaTypes { get; set; }

        /// <summary>
        /// <para>This parameter is no longer provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Reserved. Not supported yet.</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The name of the project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para><notice>Either this parameter or the SourceURI parameter must be specified.</notice>
        /// The content for semantic search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Scenery of Hangzhou in April 2021</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para><notice>Either this parameter or the Query parameter must be specified. This parameter is currently valid only when the search type is specified as image and the dataset is configured with a workflow template for image-to-image search.</notice>
        /// The storage address of the source data used for retrieval. The storage address supports OSS URIs.</para>
        /// <para>The OSS address format is oss://${Bucket}/${Object}, where ${Bucket} is the name of the OSS bucket that resides in the same region as the current project, and ${Object} is the full path of the file including the file name extension.</para>
        /// <para>If you need to configure the corresponding workflow template, <a href="https://help.aliyun.com/document_detail/84454.html">contact us</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>Specifies the specific fields to return instead of all existing metadata fields. This helps reduce the size of the returned struct.</para>
        /// <para>If this parameter is left empty, all fields are returned.</para>
        /// </summary>
        [NameInMap("WithFields")]
        [Validation(Required=false)]
        public List<string> WithFields { get; set; }

    }

}
