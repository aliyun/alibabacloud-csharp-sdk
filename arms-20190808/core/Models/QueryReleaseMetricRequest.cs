// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class QueryReleaseMetricRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the change order.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a341a2f2-ed07-4257-aae9-dfb1be******</para>
        /// </summary>
        [NameInMap("ChangeOrderId")]
        [Validation(Required=false)]
        public string ChangeOrderId { get; set; }

        /// <summary>
        /// <para>The time when the change order was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1634005438000</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The type of the metric that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SystemContrast</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The ID of the Enterprise Distributed Application Service (EDAS) or Kubernetes application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8b46d03f-5947-449d-90fd-3a96c2******</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// <para>This parameter is not in use.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ProxyUserId")]
        [Validation(Required=false)]
        public string ProxyUserId { get; set; }

        /// <summary>
        /// <para>The end time of the version release.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1632798718632</para>
        /// </summary>
        [NameInMap("ReleaseEndTime")]
        [Validation(Required=false)]
        public long? ReleaseEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the version release.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1632798686692</para>
        /// </summary>
        [NameInMap("ReleaseStartTime")]
        [Validation(Required=false)]
        public long? ReleaseStartTime { get; set; }

        /// <summary>
        /// <para>The service that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clothservice</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

    }

}
