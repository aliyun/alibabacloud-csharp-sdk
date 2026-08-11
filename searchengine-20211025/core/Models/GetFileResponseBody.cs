// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2AE63638-5420-56DC-BF59-37D8174039A0</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The index information.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public GetFileResponseBodyResult Result { get; set; }
        public class GetFileResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The content of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;summarys&quot;:{&quot;parameter&quot;:{&quot;file_compressor&quot;:&quot;zstd&quot;},&quot;summary_fields&quot;:[&quot;id&quot;]},&quot;file_compress&quot;:[{&quot;name&quot;:&quot;file_compressor&quot;,&quot;type&quot;:&quot;zstd&quot;},{&quot;name&quot;:&quot;no_compressor&quot;,&quot;type&quot;:&quot;&quot;}],&quot;indexs&quot;:[{&quot;index_fields&quot;:&quot;name&quot;,&quot;index_name&quot;:&quot;ids&quot;,&quot;index_type&quot;:&quot;STRING&quot;},{&quot;has_primary_key_attribute&quot;:true,&quot;index_fields&quot;:&quot;id&quot;,&quot;is_primary_key_sorted&quot;:false,&quot;index_name&quot;:&quot;id&quot;,&quot;index_type&quot;:&quot;PRIMARYKEY64&quot;}],&quot;attributes&quot;:[{&quot;file_compress&quot;:&quot;no_compressor&quot;,&quot;field_name&quot;:&quot;id&quot;}],&quot;fields&quot;:[{&quot;user_defined_param&quot;:{},&quot;compress_type&quot;:&quot;uniq&quot;,&quot;field_type&quot;:&quot;STRING&quot;,&quot;field_name&quot;:&quot;id&quot;},{&quot;compress_type&quot;:&quot;uniq&quot;,&quot;field_type&quot;:&quot;STRING&quot;,&quot;field_name&quot;:&quot;name&quot;}],&quot;table_name&quot;:&quot;api&quot;}</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ha-cn-pl32rf0****_test_api</para>
            /// </summary>
            [NameInMap("dataSource")]
            [Validation(Required=false)]
            public string DataSource { get; set; }

            /// <summary>
            /// <para>The extended information.</para>
            /// </summary>
            [NameInMap("extend")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> Extend { get; set; }

            /// <summary>
            /// <para>The full path of the file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/schema.json</para>
            /// </summary>
            [NameInMap("fullPathName")]
            [Validation(Required=false)]
            public string FullPathName { get; set; }

            /// <summary>
            /// <para>Indicates whether the path points to a directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("isDir")]
            [Validation(Required=false)]
            public bool? IsDir { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testFile</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The number of shards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("partition")]
            [Validation(Required=false)]
            public long? Partition { get; set; }

        }

    }

}
