// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class AddMarketingFlowShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the campaign.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value example value.</para>
        /// </summary>
        [NameInMap("ActivityDesc")]
        [Validation(Required=false)]
        public string ActivityDesc { get; set; }

        /// <summary>
        /// <para>The name of the node instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value example value.</para>
        /// </summary>
        [NameInMap("ActivityName")]
        [Validation(Required=false)]
        public string ActivityName { get; set; }

        /// <summary>
        /// <para>The business code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value.</para>
        /// </summary>
        [NameInMap("BizCode")]
        [Validation(Required=false)]
        public string BizCode { get; set; }

        /// <summary>
        /// <para>The business extension information. Default value: an empty collection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("BizExtend")]
        [Validation(Required=false)]
        public string BizExtendShrink { get; set; }

        /// <summary>
        /// <para>The cron expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value example value example value.</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value example value example value.</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The trigger method of the baseline scan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Schedule</b>: Triggered by a periodic configuration task.</description></item>
        /// <item><description><b>Manual</b>: Manually triggered.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value.</para>
        /// </summary>
        [NameInMap("ExecutionType")]
        [Validation(Required=false)]
        public string ExecutionType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The parameter flag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value.</para>
        /// </summary>
        [NameInMap("ParamFlag")]
        [Validation(Required=false)]
        public string ParamFlag { get; set; }

        /// <summary>
        /// <para>The API parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string ParamsShrink { get; set; }

        /// <summary>
        /// <para>The code of the associated flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value.</para>
        /// </summary>
        [NameInMap("RelatedFlowCode")]
        [Validation(Required=false)]
        public string RelatedFlowCode { get; set; }

        /// <summary>
        /// <para>The name of the associated flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value.</para>
        /// </summary>
        [NameInMap("RelatedFlowName")]
        [Validation(Required=false)]
        public string RelatedFlowName { get; set; }

        /// <summary>
        /// <para>The ID of the related group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("RelatedGroupId")]
        [Validation(Required=false)]
        public long? RelatedGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value.</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
