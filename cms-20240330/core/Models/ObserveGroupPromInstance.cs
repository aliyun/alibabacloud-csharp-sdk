// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ObserveGroupPromInstance : TeaModel {
        /// <summary>
        /// <para>The ID of the Managed Service for Prometheus instance, such as rw-xxxxxxxxxx.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prom-12345</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The source of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system: The system automatically identifies the instance based on the workspace or UModel.</description></item>
        /// <item><description>custom: The user manually selects the instance in the console.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prometheus</para>
        /// </summary>
        [NameInMap("kind")]
        [Validation(Required=false)]
        public string Kind { get; set; }

        /// <summary>
        /// <para>The region where the Managed Service for Prometheus instance resides. If this parameter is left empty, the backend automatically populates the region based on the workspace to which the observation group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The time when the record was written or selected. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-15 10:30:00</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

    }

}
