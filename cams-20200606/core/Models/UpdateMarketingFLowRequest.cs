// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateMarketingFLowRequest : TeaModel {
        /// <summary>
        /// <para>The code of the campaign to be updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>115311507XXXX49888</para>
        /// </summary>
        [NameInMap("ActivityCode")]
        [Validation(Required=false)]
        public string ActivityCode { get; set; }

        /// <summary>
        /// <para>The description of the campaign.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Campaign description</para>
        /// </summary>
        [NameInMap("ActivityDesc")]
        [Validation(Required=false)]
        public string ActivityDesc { get; set; }

        /// <summary>
        /// <para>The ID of the campaign to be updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>674574575658675XX</para>
        /// </summary>
        [NameInMap("ActivityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// <para>The name of the campaign.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ActivityName")]
        [Validation(Required=false)]
        public string ActivityName { get; set; }

        /// <summary>
        /// <para>The cron expression for periodic scheduling.</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>The end time in the YYYY-MM-DD HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-26 09:59:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The execution method. Set the value to 1, which indicates cron.</para>
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
        /// <para>Specifies whether to pass custom parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Y: Pass custom parameters. N: Do not pass parameters</para>
        /// </summary>
        [NameInMap("ParamFlag")]
        [Validation(Required=false)]
        public string ParamFlag { get; set; }

        /// <summary>
        /// <para>The custom parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;testEmail&quot;:&quot;wy****<a href="mailto:999@alibaba-inc.com">999@alibaba-inc.com</a>&quot;}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public Dictionary<string, object> Params { get; set; }

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
        /// <para>The start time in the YYYY-MM-DD HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-11-25 09:59:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
