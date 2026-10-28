// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class SpotBidPreviewItem : TeaModel {
        /// <summary>
        /// <para>Specifies whether it is active.</para>
        /// </summary>
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// <para>Specifies whether cross-super-node zones are allowed.</para>
        /// </summary>
        [NameInMap("allowCrossHpnZone")]
        [Validation(Required=false)]
        public bool? AllowCrossHpnZone { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cluster1</para>
        /// </summary>
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The GC level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1</para>
        /// </summary>
        [NameInMap("gcLevel")]
        [Validation(Required=false)]
        public string GcLevel { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ml.gp7vf.16.40xlarge</para>
        /// </summary>
        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc1abcdefg12345</para>
        /// </summary>
        [NameInMap("jobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The maximum discount price.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.4</para>
        /// </summary>
        [NameInMap("maxDiscount")]
        [Validation(Required=false)]
        public double? MaxDiscount { get; set; }

        /// <summary>
        /// <para>The message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bid succeeded</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pre-bid name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>preview-xxxx</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The phase.</para>
        /// </summary>
        [NameInMap("phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The number of replicas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

    }

}
