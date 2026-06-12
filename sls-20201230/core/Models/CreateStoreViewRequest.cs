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
        /// <item><description><para>The name can contain only lowercase letters, digits, and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>The name must start with a lowercase letter.</para>
        /// </description></item>
        /// <item><description><para>The name must be 3 to 62 characters in length.</para>
        /// </description></item>
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
        /// <para>The type of the dataset. Set this parameter to metricstore to create a Metricstore dataset. Set this parameter to logstore to create a Logstore dataset.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logstore</para>
        /// </summary>
        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

        /// <summary>
        /// <para>A list of Logstores or Metricstores.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("stores")]
        [Validation(Required=false)]
        public List<StoreViewStore> Stores { get; set; }

    }

}
