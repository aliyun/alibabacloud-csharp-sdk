// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdateMarketingFLowRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>115311507XXXX49888</para>
        /// </summary>
        [NameInMap("ActivityCode")]
        [Validation(Required=false)]
        public string ActivityCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("ActivityDesc")]
        [Validation(Required=false)]
        public string ActivityDesc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>674574575658675XX</para>
        /// </summary>
        [NameInMap("ActivityId")]
        [Validation(Required=false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ActivityName")]
        [Validation(Required=false)]
        public string ActivityName { get; set; }

        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-11-26 09:59:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("ParamFlag")]
        [Validation(Required=false)]
        public string ParamFlag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;testEmail&quot;:&quot;wy****<a href="mailto:999@alibaba-inc.com">999@alibaba-inc.com</a>&quot;}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public Dictionary<string, object> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cf-kr3k31**mfeir8w</para>
        /// </summary>
        [NameInMap("RelatedFlowCode")]
        [Validation(Required=false)]
        public string RelatedFlowCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>testflow</para>
        /// </summary>
        [NameInMap("RelatedFlowName")]
        [Validation(Required=false)]
        public string RelatedFlowName { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>2025-11-25 09:59:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
