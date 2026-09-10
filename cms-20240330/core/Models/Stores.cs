// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class Stores : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The SLS project name. This field has been moved to DatasourceConfigUnified.project. Using this field in write paths returns HTTP status code 400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-sls-project</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        [Obsolete]
        public string Project { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The region ID. This field has been moved to DatasourceConfigUnified.regionId. Using this field in write paths returns HTTP status code 400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        [Obsolete]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the SLS Store.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-log-store</para>
        /// </summary>
        [NameInMap("store")]
        [Validation(Required=false)]
        public string Store { get; set; }

        /// <summary>
        /// <para>The store type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>LOG: Logstore.</description></item>
        /// <item><description>METRIC: Metricstore.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LOG</para>
        /// </summary>
        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

    }

}
