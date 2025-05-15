// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_cnp20230828.Models
{
    public class GetExperimentResultDataRequest : TeaModel {
        /// <summary>
        /// <para>Experiment ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>234</para>
        /// </summary>
        [NameInMap("ExperimentId")]
        [Validation(Required=false)]
        public long? ExperimentId { get; set; }

        /// <summary>
        /// <para>Hostname</para>
        /// 
        /// <b>Example:</b>
        /// <para>iZj6ccwd7zwfms7hzaz2riZ</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>Resource Group Id</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-sfjgskdfj3k4</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Workload Type</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI</para>
        /// </summary>
        [NameInMap("WorkloadType")]
        [Validation(Required=false)]
        public string WorkloadType { get; set; }

    }

}
