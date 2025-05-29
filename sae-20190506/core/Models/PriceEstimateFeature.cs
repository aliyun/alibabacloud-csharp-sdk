// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class PriceEstimateFeature : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AppCount")]
        [Validation(Required=false)]
        public long? AppCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Web/MicroService</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CpuCore")]
        [Validation(Required=false)]
        public float? CpuCore { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Request/Always</para>
        /// </summary>
        [NameInMap("CpuStrategy")]
        [Validation(Required=false)]
        public string CpuStrategy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>L1</para>
        /// </summary>
        [NameInMap("CpuUtilLevel")]
        [Validation(Required=false)]
        public string CpuUtilLevel { get; set; }

        [NameInMap("CpuUtilMetrics")]
        [Validation(Required=false)]
        public List<float?> CpuUtilMetrics { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableCpuIdle")]
        [Validation(Required=false)]
        public bool? EnableCpuIdle { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test/Production</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("EphemeralStorageGiB")]
        [Validation(Required=false)]
        public long? EphemeralStorageGiB { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("HighLoadInstanceCount")]
        [Validation(Required=false)]
        public long? HighLoadInstanceCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HighLoadQps")]
        [Validation(Required=false)]
        public float? HighLoadQps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("HighLoadSeconds")]
        [Validation(Required=false)]
        public long? HighLoadSeconds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("InstanceQps")]
        [Validation(Required=false)]
        public float? InstanceQps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("InternetOutboundGiB")]
        [Validation(Required=false)]
        public float? InternetOutboundGiB { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LowLoadInstanceCount")]
        [Validation(Required=false)]
        public long? LowLoadInstanceCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LowLoadQps")]
        [Validation(Required=false)]
        public float? LowLoadQps { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("LowLoadSeconds")]
        [Validation(Required=false)]
        public long? LowLoadSeconds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxInstanceCount")]
        [Validation(Required=false)]
        public long? MaxInstanceCount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MemoryGiB")]
        [Validation(Required=false)]
        public float? MemoryGiB { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinInstanceCount")]
        [Validation(Required=false)]
        public long? MinInstanceCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>std</para>
        /// </summary>
        [NameInMap("NewSaeVersion")]
        [Validation(Required=false)]
        public string NewSaeVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("NoneLoadInstanceCount")]
        [Validation(Required=false)]
        public long? NoneLoadInstanceCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>79200</para>
        /// </summary>
        [NameInMap("NoneLoadSeconds")]
        [Validation(Required=false)]
        public long? NoneLoadSeconds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>haiguang</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
