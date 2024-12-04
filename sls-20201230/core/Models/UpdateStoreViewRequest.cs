// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateStoreViewRequest : TeaModel {
        /// <summary>
        /// <para>The type of the dataset.</para>
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
