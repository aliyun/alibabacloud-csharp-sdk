// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateStoreViewRequest : TeaModel {
        /// <summary>
        /// <para>The name of the dataset.</para>
        /// <list type="bullet">
        /// <item><description>The name can contain lowercase letters, digits, and underscores (_).</description></item>
        /// <item><description>The name must start with a lowercase letter.</description></item>
        /// <item><description>The name must be 3 to 62 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_storeview</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the dataset. Valid values: metricstore and logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logstore</para>
        /// </summary>
        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

        /// <summary>
        /// <para>The Logstores or Metricstores.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("stores")]
        [Validation(Required=false)]
        public List<StoreViewStore> Stores { get; set; }

    }

}
