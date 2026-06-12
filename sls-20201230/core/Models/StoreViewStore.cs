// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class StoreViewStore : TeaModel {
        /// <summary>
        /// <para>The name of the project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali-test-project</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>The query filter statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job: IT | select name, age, gender from log</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The name of the LogStore or MetricStore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-logstore</para>
        /// </summary>
        [NameInMap("storeName")]
        [Validation(Required=false)]
        public string StoreName { get; set; }

    }

}
