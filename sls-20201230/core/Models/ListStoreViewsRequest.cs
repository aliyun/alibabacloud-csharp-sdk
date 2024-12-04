// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListStoreViewsRequest : TeaModel {
        /// <summary>
        /// <para>The dataset name that is used for fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_storeview</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The offset of the datasets to return. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// <para>The number of datasets to return. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>The type of the datasets to return. By default, datasets are not filtered by type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>metricstore</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>logstore</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>logstore</para>
        /// </summary>
        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

    }

}
