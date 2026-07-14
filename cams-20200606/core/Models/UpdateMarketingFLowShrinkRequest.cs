// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateMarketingFLowShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The code of the campaign to modify.</para>
        /// 
        /// <b>Example:</b>
        /// <para>115311507XXXX49888</para>
        /// </summary>
        [NameInMap("ActivityCode")]
        [Validation(Required=false)]
        public string ActivityCode { get; set; }

        /// <summary>
        /// <para>The campaign description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>活动描述</para>
        /// </summary>
        [NameInMap("ActivityDesc")]
        [Validation(Required=false)]
        public string ActivityDesc { get; set; }

        /// <summary>
        /// <para>The ID of the campaign to modify.</para>
        /// 
        /// <b>Example:</b>
        /// <para>674574575658675XX</para>
        /// </summary>
        [NameInMap("ActivityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// <para>The campaign name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ActivityName")]
        [Validation(Required=false)]
        public string ActivityName { get; set; }

        /// <summary>
        /// <para>The cron expression for timed scheduling.</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>The end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-26 09:59:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The execution method. Set this parameter to 1 (cron).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExecutionType")]
        [Validation(Required=false)]
        public string ExecutionType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use custom pass-through parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y:传入自定义参数 N:不传参数</para>
        /// </summary>
        [NameInMap("ParamFlag")]
        [Validation(Required=false)]
        public string ParamFlag { get; set; }

        /// <summary>
        /// <para>The custom pass-through parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;testEmail&quot;:&quot;wy****<a href="mailto:999@alibaba-inc.com">999@alibaba-inc.com</a>&quot;}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string ParamsShrink { get; set; }

        /// <summary>
        /// <para>The code of the associated flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cf-kr3k31**mfeir8w</para>
        /// </summary>
        [NameInMap("RelatedFlowCode")]
        [Validation(Required=false)]
        public string RelatedFlowCode { get; set; }

        /// <summary>
        /// <para>The name of the associated flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testflow</para>
        /// </summary>
        [NameInMap("RelatedFlowName")]
        [Validation(Required=false)]
        public string RelatedFlowName { get; set; }

        /// <summary>
        /// <para>The ID of the associated group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>114345654645XX</para>
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
        /// <para>2025-11-25 09:59:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
