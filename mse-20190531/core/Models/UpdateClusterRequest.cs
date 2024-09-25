// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateClusterRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The alias of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster-1</para>
        /// </summary>
        [NameInMap("ClusterAliasName")]
        [Validation(Required=false)]
        public string ClusterAliasName { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-cn-78v1l83****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The end time of the O\&amp;M window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06:00</para>
        /// </summary>
        [NameInMap("MaintenanceEndTime")]
        [Validation(Required=false)]
        public string MaintenanceEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the O\&amp;M window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02:00</para>
        /// </summary>
        [NameInMap("MaintenanceStartTime")]
        [Validation(Required=false)]
        public string MaintenanceStartTime { get; set; }

        /// <summary>
        /// <para>The extended request parameters in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

    }

}
