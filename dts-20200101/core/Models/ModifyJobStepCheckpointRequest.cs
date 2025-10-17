// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyJobStepCheckpointRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>l5512es7w15****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wn3z4ukia9wi9xu_0004_0000</para>
        /// </summary>
        [NameInMap("JobStepId")]
        [Validation(Required=false)]
        public string JobStepId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1760406***</para>
        /// </summary>
        [NameInMap("NewCheckPoint")]
        [Validation(Required=false)]
        public long? NewCheckPoint { get; set; }

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
        /// <para>rg-aek2ilvoxlrd***</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
