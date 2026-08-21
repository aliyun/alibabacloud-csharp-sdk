// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class CreateAlertStrategyRequest : TeaModel {
        [NameInMap("X-Debug-Id")]
        [Validation(Required=false)]
        public string XDebugId { get; set; }

        /// <summary>
        /// <para>Specifies whether the alert policy is enabled.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The Kubernetes label.</para>
        /// </summary>
        [NameInMap("k8sLabel")]
        [Validation(Required=false)]
        public bool? K8sLabel { get; set; }

        /// <summary>
        /// <para>The Policy Name of the alerting policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>strategy1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The details of the alert policy.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("strategy")]
        [Validation(Required=false)]
        public CreateAlertStrategyRequestStrategy Strategy { get; set; }
        public class CreateAlertStrategyRequestStrategy : TeaModel {
            /// <summary>
            /// <para>The collection of clusters for which alerts are received.</para>
            /// </summary>
            [NameInMap("clusters")]
            [Validation(Required=false)]
            public List<string> Clusters { get; set; }

            /// <summary>
            /// <para>The alert contacts.</para>
            /// </summary>
            [NameInMap("destinations")]
            [Validation(Required=false)]
            public List<int?> Destinations { get; set; }

            /// <summary>
            /// <para>The collection of anomaly items for which alerts are received.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<string> Items { get; set; }

        }

        [NameInMap("x-sysom-invoke-source")]
        [Validation(Required=false)]
        public string XSysomInvokeSource { get; set; }

    }

}
