// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class WriteFeatureViewTableRequest : TeaModel {
        /// <summary>
        /// <para>The write mode.</para>
        /// <list type="bullet">
        /// <item><description><para>Overwrite: Overwrites existing data.</para>
        /// </description></item>
        /// <item><description><para>Merge: Merges the new data with existing data.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Merge</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The partitions to write to.</para>
        /// </summary>
        [NameInMap("Partitions")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> Partitions { get; set; }

        /// <summary>
        /// <para>The file data source.</para>
        /// </summary>
        [NameInMap("UrlDatasource")]
        [Validation(Required=false)]
        public WriteFeatureViewTableRequestUrlDatasource UrlDatasource { get; set; }
        public class WriteFeatureViewTableRequestUrlDatasource : TeaModel {
            /// <summary>
            /// <para>The file delimiter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>,</para>
            /// </summary>
            [NameInMap("Delimiter")]
            [Validation(Required=false)]
            public string Delimiter { get; set; }

            /// <summary>
            /// <para>Specifies whether to omit the header from the source file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OmitHeader")]
            [Validation(Required=false)]
            public bool? OmitHeader { get; set; }

            /// <summary>
            /// <para>The data source path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx.xxx.com/file.csv</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

    }

}
