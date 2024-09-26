// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ModifyDynamicConfigRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;dts.datamove.source.rps.max\&quot;:5000,\&quot;dts.datamove.source.bps.max\&quot;:10485760}</para>
        /// </summary>
        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public string ConfigList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ta7w132u12h****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableLimit")]
        [Validation(Required=false)]
        public bool? EnableLimit { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>07</para>
        /// </summary>
        [NameInMap("JobCode")]
        [Validation(Required=false)]
        public string JobCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
