// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CloneDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the target data source. The name can contain letters, digits, and underscores (_), and cannot start with a digit or an underscore. The name can be up to 60 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_holo_datasource</para>
        /// </summary>
        [NameInMap("CloneDataSourceName")]
        [Validation(Required=false)]
        public string CloneDataSourceName { get; set; }

        /// <summary>
        /// <para>The ID of the data source, which is the unique identifier of the data source. You can call the ListDataSources operation to query existing data sources and their unique IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1603612</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
