// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PrometheusManagedInstance : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-03-11T08:21:58Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rum-xxx</para>
        /// </summary>
        [NameInMap("prometheusInstanceId")]
        [Validation(Required=false)]
        public string PrometheusInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rum-xxx</para>
        /// </summary>
        [NameInMap("prometheusInstanceName")]
        [Validation(Required=false)]
        public string PrometheusInstanceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>workspace-test</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
