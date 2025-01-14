// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CloneDataSourceRequest : TeaModel {
        /// <summary>
        /// <para>The name of the destination data source The name can contain letters, digits, and underscores (_), and must start with a letter. It cannot exceed 60 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo_holo_datasource</para>
        /// </summary>
        [NameInMap("CloneDataSourceName")]
        [Validation(Required=false)]
        public string CloneDataSourceName { get; set; }

        /// <summary>
        /// <para>The data source ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16036</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
