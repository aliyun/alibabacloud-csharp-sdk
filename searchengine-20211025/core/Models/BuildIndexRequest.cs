// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class BuildIndexRequest : TeaModel {
        /// <summary>
        /// <para>The method to rebuild the index. Valid values: api and indexRecover.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api</para>
        /// </summary>
        [NameInMap("buildMode")]
        [Validation(Required=false)]
        public string BuildMode { get; set; }

        /// <summary>
        /// <para>The name of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ha-cn-pl32rf0****_test_api</para>
        /// </summary>
        [NameInMap("dataSourceName")]
        [Validation(Required=false)]
        public string DataSourceName { get; set; }

        /// <summary>
        /// <para>The type of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>odps</para>
        /// </summary>
        [NameInMap("dataSourceType")]
        [Validation(Required=false)]
        public string DataSourceType { get; set; }

        /// <summary>
        /// <para>The UNIX timestamp in seconds. This parameter is an integer. This parameter is required if data is pushed to the data source using an API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640867288</para>
        /// </summary>
        [NameInMap("dataTimeSec")]
        [Validation(Required=false)]
        public int? DataTimeSec { get; set; }

        /// <summary>
        /// <para>The data center of the data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sz_vpc_domain_1</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The backfill ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>160131146</para>
        /// </summary>
        [NameInMap("generation")]
        [Validation(Required=false)]
        public long? Generation { get; set; }

        /// <summary>
        /// <para>Required if dataSourceType is set to odps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ds=20201010</para>
        /// </summary>
        [NameInMap("partition")]
        [Validation(Required=false)]
        public string Partition { get; set; }

        /// <summary>
        /// <para>The relative path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test/dir</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The tag of the Data Lake Formation (DLF) data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
