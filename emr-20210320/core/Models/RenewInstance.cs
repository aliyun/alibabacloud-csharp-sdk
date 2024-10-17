// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class RenewInstance : TeaModel {
        /// <summary>
        /// <para>emr实例续费时长。</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("EmrRenewDuration")]
        [Validation(Required=false)]
        public int? EmrRenewDuration { get; set; }

        /// <summary>
        /// <para>emr实例续费时长单位。</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("EmrRenewDurationUnit")]
        [Validation(Required=false)]
        public string EmrRenewDurationUnit { get; set; }

        /// <summary>
        /// <para>节点ID。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1cudc25w2bfwl5****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>续费时长。</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("RenewDuration")]
        [Validation(Required=false)]
        public int? RenewDuration { get; set; }

        /// <summary>
        /// <para>付费时长单位。</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("RenewDurationUnit")]
        [Validation(Required=false)]
        public string RenewDurationUnit { get; set; }

    }

}
