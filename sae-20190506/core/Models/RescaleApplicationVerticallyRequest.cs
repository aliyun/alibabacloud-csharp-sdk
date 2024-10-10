// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class RescaleApplicationVerticallyRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0099b7be-5f5b-4512-a7fc-56049ef1****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The destination CPU specification. Unit: millicore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public string Cpu { get; set; }

        /// <summary>
        /// <para>The destination memory size. Unit: MB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

        [NameInMap("autoEnableApplicationScalingRule")]
        [Validation(Required=false)]
        public bool? AutoEnableApplicationScalingRule { get; set; }

        [NameInMap("minReadyInstanceRatio")]
        [Validation(Required=false)]
        public int? MinReadyInstanceRatio { get; set; }

        [NameInMap("minReadyInstances")]
        [Validation(Required=false)]
        public int? MinReadyInstances { get; set; }

    }

}
